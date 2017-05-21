using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using PlayerList = System.Collections.Generic.List<WheelOfFortune.Player>;
using PlayerNameLabelList = System.Collections.Generic.List<System.Windows.Forms.Label>;
using PlayerPointsLabelList = System.Collections.Generic.List<System.Windows.Forms.Label>;
using LetterMap = System.Collections.Generic.Dictionary<string, int>;

namespace WheelOfFortune
{
    public partial class MainForm : Form
    {
        SecretWord secretWord;
        Letter[] word;
        Wheel wheelofFortune;
        bool wheelIsMoved;
        float startWheelTimes;
        float wheelTimes;
        Timer gameTimer;
        Timer wheelTimer;
        Button[] button;
        Button[] vowel;
        Button[] consonant;
        LetterMap letterMap = new LetterMap(); // 0=not,1=hit, 2=miss

        Game game;
        PlayerList players = new PlayerList();
        PlayerNameLabelList playerNameLabels = new PlayerNameLabelList();
        PlayerPointsLabelList playerPointLabels = new PlayerPointsLabelList();
        int currentPlayerIx = 0;

        public MainForm()
        {
            var wordBank = new WordBank();
            LoadWords(wordBank);
            var puzzle = wordBank.GetPuzzle();

            LoadPlayers();
            FigureOutWhoseTurn();
            wheelofFortune = new Wheel();
            secretWord = new SecretWord(puzzle.Answer);
            word = new Letter[secretWord.size];
            wheelIsMoved = false;
            wheelTimes = 100;
            InitializeComponent();
            InitializeLabelArrays();
            drawSecretWord();
            setPlayerColors();
            lblInfo2.Text = "";
            lblCategory.Text = "Category: " + puzzle.Category;
            wheelTimer = new Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += wheelTimer_Tick;


            button = new Button[30];
            vowel = new Button[6];
            consonant = new Button[20];

            button[0] = btnA;
            button[1] = btnB;
            button[2] = btnC;
            button[3] = btnD;
            button[4] = btnE;
            button[5] = btnF;
            button[6] = btnG;
            button[7] = btnH;
            button[8] = btnI;
            button[9] = btnJ;
            button[10] = btnK;
            button[11] = btnL;
            button[12] = btnM;
            button[13] = btnN;
            button[14] = btnO;
            button[15] = btnP;
            button[16] = btnQ;
            button[17] = btnR;
            button[18] = btnS;
            button[19] = btnT;
            button[20] = btnU;
            button[21] = btnV;
            button[22] = btnW;
            button[23] = btnX;
            button[24] = btnY;
            button[25] = btnZ;
            button[26] = btnSpace;
            button[27] = btnApostrophe;
            button[28] = btnAmpersand;
            button[29] = btnHyphen;

            vowel[0] = btnA;
            vowel[1] = btnE;
            vowel[2] = btnI;
            vowel[3] = btnO;
            vowel[4] = btnU;
            vowel[5] = btnY;

            consonant[0] = btnB;
            consonant[1] = btnC;
            consonant[2] = btnD;
            consonant[3] = btnF;
            consonant[4] = btnG;
            consonant[5] = btnH;
            consonant[6] = btnJ;
            consonant[7] = btnK;
            consonant[8] = btnL;
            consonant[9] = btnM;
            consonant[10] = btnN;
            consonant[11] = btnP;
            consonant[12] = btnQ;
            consonant[13] = btnR;
            consonant[14] = btnS;
            consonant[15] = btnT;
            consonant[16] = btnV;
            consonant[17] = btnW;
            consonant[18] = btnX;
            consonant[19] = btnZ;

            for (int i = 0; i < button.Length; i++)
            {
                button[i].Enabled = true;         //active flag
                button[i].Visible = false;        //visibility flag
                letterMap[button[i].Text] = 0; // not guessed
            }

            game = new Game();

            gameTimer = new Timer();
            gameTimer.Interval = 100;
            gameTimer.Tick += gameTimer_Tick;
            Prompt();

            gameTimer.Start();
            updateLetterButtons();
        }

        private void LoadWords(WordBank wordBank)
        {
            var bankLoader = new BankLoader();
            string curpath = System.IO.Directory.GetCurrentDirectory();
            foreach (var filepath in System.IO.Directory.GetFiles(curpath, "*.txt"))
            {
                bankLoader.Load(wordBank, filepath, "Puzzle");
            }
        }
        private void AddPlayer(string name, int points)
        {
            var player = new Player(name) { points = points };
            players.Add(player);
        }
        private void FigureOutWhoseTurn()
        {
            // Figure out starting player turn
            currentPlayerIx = 0;
            for (int ix = 1; ix < players.Count; ++ix)
            {
                string startingPlayerName = PersistenceHelper.SettingsFactory.Get().GetString("StartingPlayerName", "");
                if (players[ix].name == startingPlayerName)
                {
                    currentPlayerIx = ix;
                    break;
                }
            }
        }
        private void InitializeLabelArrays()
        {
            playerNameLabels.Add(lblPlayer1Name);
            playerNameLabels.Add(lblPlayer2Name);
            playerNameLabels.Add(lblPlayer3Name);
            playerNameLabels.Add(lblPlayer4Name);
            playerNameLabels.Add(lblPlayer5Name);
            playerNameLabels.Add(lblPlayer6Name);
            playerPointLabels.Add(lblScore1);
            playerPointLabels.Add(lblScore2);
            playerPointLabels.Add(lblScore3);
            playerPointLabels.Add(lblScore4);
            playerPointLabels.Add(lblScore5);
            playerPointLabels.Add(lblScore6);
            for (int ix = 0; ix < 6; ++ix)
            {
                bool ingame = (ix < players.Count);
                playerNameLabels[ix].Visible = ingame;
                playerPointLabels[ix].Visible = ingame;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HandleGuess(" ", system: true);
            HandleGuess("'", system: true);
            HandleGuess("&", system: true);
            HandleGuess("-", system: true);
            Prompt();
        }
        private void Prompt()
        {
            if (game.step == 2)
            {
                if (CurrentPlayer.points >= 125)
                {
                    string prompt = string.Format("{0}: Play for ${1} (or buy a vowel for $125)", CurrentPlayer.name, game.rate);
                    lblInfo.Text = prompt;
                }
                else
                {
                    string prompt = string.Format("{0}: Play for ${1}", CurrentPlayer.name, game.rate);
                    lblInfo.Text = prompt;
                }
            }
            else
            {
                if (CurrentPlayer.points >= 125)
                {
                    string prompt = string.Format("{0}: Buy a vowel for $125 or spin the wheel", CurrentPlayer.name);
                    lblInfo.Text = prompt;
                }
                else
                {
                    string prompt = string.Format("{0}: Spin the wheel", CurrentPlayer.name);
                    lblInfo.Text = prompt;
                }
            }
        }

        bool isVowel(string ch)
        {
            return ch == "A" || ch == "E" || ch == "I" || ch == "O" || ch == "U" || ch == "Y";
        }
        private static bool eqstr(string s1, string s2)
        {
            return string.Compare(s1, s2, ignoreCase: true) == 0;
        }
        private Player CurrentPlayer { get { return players[currentPlayerIx]; } }
        private void handleButton(object sender, EventArgs e)
        {
            Button chosenButton = (Button)sender;
            string guessLetter = chosenButton.Text;
            HandleGuess(guessLetter, system: false);
        }
        private void HandleGuess(string guessLetter, bool system)
        {
            int hits = 0;
            bool buyingVowel = isVowel(guessLetter);
            if (buyingVowel)
            {
                CurrentPlayer.points -= 125;
            }

            for (int i = 0; i < secretWord.size; i++)
            {
                if (eqstr(secretWord.field[i].Text, guessLetter))
                {
                    secretWord.field[i].UseSystemPasswordChar = false;
                    if (buyingVowel)
                    {
                        if (hits == 0)
                        {
                            updateLetterButtons();
                        }
                    }
                    else
                    {
                        game.guessedLetter += 1;
                        CurrentPlayer.points += game.rate;
                        updateLetterButtons();
                    }

                    ++hits;
                    secretWord.value++;
                }
            }

            letterMap[guessLetter] = (hits == 0 ? 1 : 2);
            if (!system)
            {
                if (buyingVowel)
                {
                    string msg = string.Format("{0} bought the vowel {1} and got {2} match(es)",
                        CurrentPlayer.name, guessLetter, hits);
                    lblInfo2.Text = msg;
                }
                else
                {
                    string msg = string.Format("{0} guessed the consonant {1} and got {2} match(es)",
                        CurrentPlayer.name, guessLetter, hits);
                    lblInfo2.Text = msg;
                }
                if (hits == 0)
                {
                    game.guessedLetter = 0;
                    game.step = 1;
                    incrementPlayer();
                }
                else
                {
                    if (!buyingVowel)
                    {
                        game.step = 3;
                    }
                }
            }

            UpdateAllPlayerPoints();
            updateLetterButtons();
            pctWheel.Enabled = true;
        }
        void UpdateAllPlayerPoints()
        {
            for (int ix = 0; ix < players.Count; ++ix)
            {
                playerPointLabels[ix].Text = string.Format("${0:N0}", players[ix].points);
            }
        }

        public Bitmap rotateImage()
        {
            Bitmap rotatedImage = new Bitmap(pctWheel.Width, pctWheel.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((pctWheel.Width / 2), pctWheel.Height / 2); //set the rotation point as the center into the matrix
                g.RotateTransform(wheelofFortune.angle); //rotate
                g.TranslateTransform(-pctWheel.Width / 2, -pctWheel.Height / 2); //restore rotation point into the matrix
                g.DrawImage(wheelofFortune.tempPicture, new Point(0, 0)); //draw the image on the new bitmap
            }
            return rotatedImage;
        }

        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }

        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void wheelTimer_Tick(object sender, EventArgs e)
        {
            lblInfo.Visible = false;

            if (wheelIsMoved && wheelTimes > 0)
            {
                wheelofFortune.angle += wheelTimes / 10;
                wheelofFortune.angle = wheelofFortune.angle % 360;
                RotateImage(pctWheel, wheelofFortune.picture, wheelofFortune.angle);
                wheelTimes--;
            }

            wheelofFortune.state = Convert.ToInt32(Math.Ceiling(wheelofFortune.angle / 18));

            if (wheelofFortune.state == 0)
            {
                wheelofFortune.state = 0;
            }
            else
            {
                wheelofFortune.state -= 1;
            }

            lblState.Text = Convert.ToString(wheelofFortune.angle);
            lblAngle.Text = Convert.ToString(wheelofFortune.state);
            lblWheelValue.Text = Convert.ToString(wheelofFortune.wheelState[wheelofFortune.state]);


            if (wheelTimes == 0)
            {

                game.rate = wheelofFortune.wheelState[wheelofFortune.state];
                game.hint[2] = "Playing for $" + game.rate + ".";

                wheelIsMoved = false;

                updateLetterButtons();

                if (wheelofFortune.wheelState[wheelofFortune.state] == 0)
                {
                    // Bankrupt
                    lblInfo2.Text = CurrentPlayer.name + ": " + game.hint[3];
                    CurrentPlayer.points -= (CurrentPlayer.points / 2);
                    incrementPlayer();
                    game.step = 1;
                    pctWheel.Enabled = true;
                }
                else if (wheelofFortune.wheelState[wheelofFortune.state] == -1)
                {
                    // Lose turn
                    lblInfo2.Text = CurrentPlayer.name + ": " + game.hint[5];
                    incrementPlayer();
                    game.step = 1;
                    pctWheel.Enabled = true;
                }
                else
                {
                    game.step = 2;
                }

                wheelTimer.Stop();
                UpdateAllPlayerPoints();
            }
        }

        private void solvePuzzle()
        {
            string guess = Interaction.InputBox(CurrentPlayer.name + " would like to solve the Puzzle. Enter your guess.", "Solve the Puzzle", "(guess)");
            if (guess != "")
            {
                if (guess.ToUpper() == secretWord.password.ToUpper())
                {
                    CurrentPlayer.guessedWord = true;
                }
                else
                {
                    lblInfo2.Text = CurrentPlayer.name + ": failed to solve the puzzle.";
                    incrementPlayer();
                    pctWheel.Enabled = true;
                    game.step = 1;
                }
            }
        }

        private void incrementPlayer()
        {
            ++currentPlayerIx;
            if (currentPlayerIx >= players.Count)
            {
                currentPlayerIx = 0;
            }
            setPlayerColors();
        }

        private void setPlayerColors()
        {
            for (int ix = 0; ix < players.Count; ++ix)
            {
                playerNameLabels[ix].ForeColor = (currentPlayerIx == ix ? Color.Red : Color.Black);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            switch (game.step)
            {
                case 1:
                    step1(); // spin (all letters hidden)
                    break;
                case 2:
                    step2(); // pick a letter (cannot spin)
                    break;
                case 3:
                    step3(); // buy a vowel or spin (consonants hidden)
                    break;
            }

            if (secretWord.value > 0 && secretWord.value == secretWord.size)
            {
                CurrentPlayer.guessedWord = true;
                secretWord.value = 0;
            }

            if (CurrentPlayer.guessedWord)
            {
                gameTimer.Stop();

                string msg = string.Format("{0} wins! You have won ${1} . Play Again? ",
                    CurrentPlayer.name, CurrentPlayer.points);
                if (DialogResult.Yes == MessageBox.Show(msg, "Alert"
                              , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
                CurrentPlayer.guessedWord = false;
            }
        }

        public void step1()
        {
            lblInfo.Visible = true;

            for (int i = 0; i < button.Length; i++)
            {
                button[i].Visible = false;
            }
            Prompt();
        }

        public void step2()
        {
            lblInfo.Visible = true;
            Prompt();
            updateLetterButtons();
            pctWheel.Enabled = false;
        }
        public void updateLetterButtons()
        {
            if (game.step != 2)
            {
                if (CurrentPlayer.points < 125)
                {
                    game.step = 1;
                }
                else
                {
                    game.step = 3;
                }
            }

            for (int i = 0; i < vowel.Length; i++)
            {
                int state = letterMap[vowel[i].Text];
                if (state == 0) // not guessed
                {
                    vowel[i].Visible = true;
                    vowel[i].Enabled = (CurrentPlayer.points >= 125);
                }
                else // guessed
                {
                    vowel[i].Visible = false;
                }
            }

            for (int i = 0; i < consonant.Length; i++)
            {
                int state = letterMap[consonant[i].Text];
                if (state == 0) // not guessed
                {
                    consonant[i].Visible = true;
                    consonant[i].Enabled = (game.step == 2);
                }
                else if (state == 1) // guessed
                {
                    consonant[i].Visible = false;
                }
            }
        }

        public void step3()
        {
            Prompt();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblInfo2.Text = "";
            pctWheel.Enabled = false;
            wheelIsMoved = true;
            Random rand = new Random();
            wheelTimes = rand.Next(150, 200);
            startWheelTimes = wheelTimes;

            for (int i = 0; i < button.Length; i++)
            {
                button[i].Visible = false;
            }
            wheelTimer.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            solvePuzzle();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePlayerInfo();
        }
        private void LoadPlayers()
        {
            var settings = PersistenceHelper.SettingsFactory.Get();
            int numPlayers = settings.GetInt("NumberPlayers", 2);
            if (numPlayers < 1) { numPlayers = 1; }
            if (numPlayers > 6) { numPlayers = 6; }
            for (int ix = 0; ix < numPlayers; ++ix)
            {
                string nameKey = string.Format("Player{0}.Name", ix);
                string defName = string.Format("Player{0}", ix+1);
                var name = settings.GetString(nameKey, defName);
                string pointsKey = string.Format("Player{0}.Points", ix);
                var points = settings.GetInt(pointsKey, 0);
                AddPlayer(name, points);
            }
        }
        private void SavePlayerInfo()
        {
            var settings = PersistenceHelper.SettingsFactory.Get();
            settings.SetInt("PlayerCount", players.Count);
            for (int ix = 0; ix < players.Count; ++ix)
            {
                string nameKey = string.Format("Player{0}.Name", ix);
                settings.SetString(nameKey, players[ix].name);
                string pointsKey = string.Format("Player{0}.Points", ix);
                settings.SetInt(pointsKey, players[ix].points);
            }
            settings.Save();
        }
    }
}
