﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using PlayerList = System.Collections.Generic.List<WheelOfFortune.Player>;
using PlayerNameLabelList = System.Collections.Generic.List<System.Windows.Forms.Label>;
using PlayerPointsLabelList = System.Collections.Generic.List<System.Windows.Forms.Label>;

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


            button = new Button[28];
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

            for (int i = 0; i < 26; i++)
            {
                button[i].IsAccessible = true;    //already chosen
                button[i].Enabled = true;         //active flag
                button[i].Visible = false;        //visibility flag
            }

            game = new Game();

            gameTimer = new Timer();
            gameTimer.Interval = 100;
            gameTimer.Tick += gameTimer_Tick;
            lblInfo.Text = game.hint[0];

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
        private void LoadPlayers()
        {
            int numPlayers = Properties.Settings.Default.NumberOfPlayers;
            if (numPlayers < 1) { numPlayers = 1; }
            if (numPlayers > 6) { numPlayers = 6; }

            AddPlayer(Properties.Settings.Default.Player1Name, Properties.Settings.Default.Player1Points);
            if (numPlayers < 2) { return; }
            AddPlayer(Properties.Settings.Default.Player2Name, Properties.Settings.Default.Player2Points);
            if (numPlayers < 3) { return; }
            AddPlayer(Properties.Settings.Default.Player3Name, Properties.Settings.Default.Player3Points);
            if (numPlayers < 4) { return; }
            AddPlayer(Properties.Settings.Default.Player4Name, Properties.Settings.Default.Player4Points);
            if (numPlayers < 5) { return; }
            AddPlayer(Properties.Settings.Default.Player5Name, Properties.Settings.Default.Player5Points);
            if (numPlayers < 6) { return; }
            AddPlayer(Properties.Settings.Default.Player6Name, Properties.Settings.Default.Player6Points);
        }
        private void FigureOutWhoseTurn()
        {
            // Figure out starting player turn
            currentPlayerIx = 0;
            for (int ix = 1; ix < players.Count; ++ix)
            {
                if (players[ix].name == Properties.Settings.Default.StartingPlayerName)
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
            handleButton(btnSpace, e);
            handleButton(btnApostrophe, e);
            handleButton(btnAmpersand, e);
            handleButton(btnHyphen, e);
            lblInfo.Text = game.hint[1];
        }

        bool isVowel(string ch)
        {
            return ch == "A" || ch == "E" || ch == "I" || ch == "O" || ch == "U" || ch == "Y";
        }
        private Player CurrentPlayer { get { return players[currentPlayerIx]; } }
        private void handleButton(object sender, EventArgs e)
        {
            Boolean ifExist = false;
            Button chosenButton = (Button)sender;
            bool buyingVowel = isVowel(chosenButton.Text);
            if (buyingVowel)
            {
                CurrentPlayer.points -= 125;
            }

            bool wasAccessible = chosenButton.IsAccessible;

            for (int i = 0; i < secretWord.size; i++)
            {
                if ((secretWord.field[i].Text.ToUpper()).Equals((chosenButton.Text.ToUpper())))
                {
                    secretWord.field[i].UseSystemPasswordChar = false;
                    chosenButton.IsAccessible = false;

                    if (buyingVowel)
                    {
                        if (!ifExist)
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

                    ifExist = true;
                    secretWord.value++;
                }
            }

            if (wasAccessible)
            {
                if (!ifExist)
                {
                    game.guessedLetter = 0;
                    game.step = 1;
                    lblInfo2.Text = CurrentPlayer.name + ": " + game.hint[4];
                    incrementPlayer();
                }
                else
                {
                    lblInfo2.Text = CurrentPlayer.name + ": bought the vowel " + chosenButton.Text;
                    if (!buyingVowel)
                    {
                        lblInfo2.Text = CurrentPlayer.name + ": guessed the consonant " + chosenButton.Text;
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

                for (int i = 0; i < button.Length; i++)
                {
                    if (button[i].IsAccessible)
                    {
                        button[i].Visible = true;
                    }
                }

                if (wheelofFortune.wheelState[wheelofFortune.state] == 0)
                {
                    // Bankrupt
                    lblInfo2.Text = CurrentPlayer.name + ": " + game.hint[3];
                    CurrentPlayer.points = 0;
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
            lblInfo.Text = game.hint[0];
        }

        public void step2()
        {
            lblInfo.Visible = true;
            lblInfo.Text = game.hint[2];
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
                if (vowel[i].IsAccessible && CurrentPlayer.points >= 125 && game.step > 1)
                {
                    vowel[i].Enabled = true;
                    vowel[i].Visible = true;
                }
                else
                {
                    vowel[i].Enabled = false;
                    vowel[i].Visible = false;
                }
            }

            for (int i = 0; i < consonant.Length; i++)
            {
                if (consonant[i].IsAccessible && game.step > 1)
                {
                    consonant[i].Enabled = (game.step == 2);
                    consonant[i].Visible = true;
                }
                else
                {
                    consonant[i].Enabled = false;
                    consonant[i].Visible = false;
                }
            }
        }

        public void step3()
        {
            lblInfo.Text = game.hint[1];
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
            Properties.Settings.Default.StartingPlayerName = CurrentPlayer.name;
            Properties.Settings.Default.Save();
        }
        private void SavePlayerInfo()
        {
            int ix = 0;
            Properties.Settings.Default.Player1Name = players[ix].name;
            Properties.Settings.Default.Player1Points = players[ix].points;
            if (players.Count < 2) { return; }
            ++ix;
            Properties.Settings.Default.Player2Name = players[ix].name;
            Properties.Settings.Default.Player2Points = players[ix].points;
            if (players.Count < 3) { return; }
            ++ix;
            Properties.Settings.Default.Player3Name = players[ix].name;
            Properties.Settings.Default.Player3Points = players[ix].points;
            if (players.Count < 4) { return; }
            ++ix;
            Properties.Settings.Default.Player4Name = players[ix].name;
            Properties.Settings.Default.Player4Points = players[ix].points;
            if (players.Count < 5) { return; }
            ++ix;
            Properties.Settings.Default.Player5Name = players[ix].name;
            Properties.Settings.Default.Player5Points = players[ix].points;
            if (players.Count < 6) { return; }
            ++ix;
            Properties.Settings.Default.Player6Name = players[ix].name;
            Properties.Settings.Default.Player6Points = players[ix].points;
        }
    }
}
