using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
        String[] words = { "BONNIE & CLYDE", "WILLY WONKA'S CHOCOLATE FACTORY", "HODGE PODGE", "SEWING & SLOT MACHINE", "MICHAEL J FOX & MARTY MCFLY", "SUPER MARIO BROTHERS", "ELLEN DEGENERES & PORTIA DE ROSSI", "OPTIMUS PRIME RIB", "RAMEN NOODLES", "POTLUCK", "YOU WASH I'LL DRY", "REDWOOD TREE", "BIG MAC MEAL", "GOOD NIGHT'S SLEEP", "ANGORA SWEATER", "TALES OF A FOURTH GRADE NOTHING", "GUNSMOKE", "CRUISE SHIP ENTERTAINER", "JUSTIN BIEBER", "BICYCLE WITH TRAINING WHEELS", "MIDNIGHT TRAIN TO GEORGIA", "WATCHING HOCKEY", "PRIME TIME EMMY AWARDS", "SATISFIED CUSTOMERS"};
        String[] category = {"DUOS", "PLACE", "RHYME TIME", "SAME NAME", "STAR AND ROLL", "FAMILY", "FAMOUS MARRIED COUPLES", "BEFORE AND AFTER", "COLLEGE LIFE", "EVENTS", "PHRASE", "LIVING THING", "FOOD", "PHRASE", "AROUND THE HOUSE", "BOOK TITLE", "CLASSIC T.V.", "OCCUPATION", "PROPER NAME", "THING", "SONG", "THINGS TO DO", "SHOW BIZ", "PEOPLE"};
        Random rand;
        int wordIndex;

        Game game;
        Player player1;
        Player player2;
        Player player3;
        Player currentplayer;

        public MainForm()
        {
            rand = new Random();
            wordIndex = rand.Next(0, words.Length);
            wheelofFortune = new Wheel();
            secretWord = new SecretWord(words[wordIndex]);
            word = new Letter[secretWord.size];
            player1 = new Player(Properties.Settings.Default.Player1Name);
            player1.points = Properties.Settings.Default.Player1Points;
            player2 = new Player(Properties.Settings.Default.Player2Name);
            player2.points = Properties.Settings.Default.Player2Points;
            player3 = new Player(Properties.Settings.Default.Player3Name);
            player3.points = Properties.Settings.Default.Player3Points;
            currentplayer = player1;
            if (player2.name == Properties.Settings.Default.StartingPlayerName)
            {
                currentplayer = player2;
            }
            else if (player3.name == Properties.Settings.Default.StartingPlayerName)
            {
                currentplayer = player3;
            }
            wheelIsMoved = false;
            wheelTimes = 100;
            InitializeComponent();
            drawSecretWord();
            setPlayerColors();
            lblInfo2.Text = "";
            lblCategory.Text = "Category: " + category[wordIndex];
            wheelTimer = new Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += wheelTimer_Tick;
            lblPlayer1Name.Text = player1.name;
            lblPlayer2Name.Text = player2.name;
            lblPlayer3Name.Text = player3.name;


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

        private void Form1_Load(object sender, EventArgs e)
        {
            handleButton(btnSpace, e);
            handleButton(btnApostrophe, e);
            handleButton(btnAmpersand, e);
            lblInfo.Text = game.hint[1];
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        bool isVowel(string ch)
        {
            return ch == "A" || ch == "E" || ch == "I" || ch == "O" || ch == "U" || ch == "Y";
        }
        private void handleButton(object sender, EventArgs e)
        {
            Boolean ifExist = false;
            Button chosenButton = (Button)sender;
            bool buyingVowel = isVowel(chosenButton.Text);
            if (buyingVowel)
            {
                currentplayer.points -= 125;
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
                        if (currentplayer == player1)
                        {
                            lblScore1.Text = "$" + Convert.ToString(currentplayer.points);
                        }
                        else if (currentplayer == player2)
                        {
                            lblScore2.Text = "$" + Convert.ToString(currentplayer.points);
                        }
                        else if (currentplayer == player3)
                        {
                            lblScore3.Text = "$" + Convert.ToString(currentplayer.points);
                        }
                    }
                    else
                    {
                        game.guessedLetter += 1;
                        currentplayer.points += game.rate;
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
                    lblInfo2.Text = currentplayer.name + ": " + game.hint[4];
                    incrementPlayer(currentplayer);
                }
                else
                {
                    lblInfo2.Text = currentplayer.name + ": bought the vowel " + chosenButton.Text;
                    if (!buyingVowel)
                    {
                        lblInfo2.Text = currentplayer.name + ": guessed the consonant " + chosenButton.Text;
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
            lblScore1.Text = "$" + Convert.ToString(player1.points);
            lblScore2.Text = "$" + Convert.ToString(player2.points);
            lblScore3.Text = "$" + Convert.ToString(player3.points);
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
                    lblInfo2.Text = currentplayer.name + ": " + game.hint[3];
                    currentplayer.points = 0;
                    incrementPlayer(currentplayer);
                    game.step = 1;
                    pctWheel.Enabled = true;
                }
                else if (wheelofFortune.wheelState[wheelofFortune.state] == -1)
                {
                    lblInfo2.Text = currentplayer.name + ": " + game.hint[5];
                    incrementPlayer(currentplayer);
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
            string guess = Interaction.InputBox(currentplayer.name + " would like to solve the Puzzle. Enter your guess.", "Solve the Puzzle", "(guess)");
            if (guess != "")
            {
                if (guess.ToUpper() == secretWord.password.ToUpper())
                {
                    currentplayer.guessedWord = true;
                }
                else
                {
                    lblInfo2.Text = currentplayer.name + ": failed to solve the puzzle.";
                    incrementPlayer(currentplayer);
                    pctWheel.Enabled = true;
                    game.step = 1;
                }
            }
        }

        private Player incrementPlayer(Player passedPlayer)
        {
            if (currentplayer == player1)
            {
                currentplayer = player2;
            }
            else if (currentplayer == player2)
            {
                currentplayer = player3;
            }
            else if (currentplayer == player3)
            {
                currentplayer = player1;
            }
            setPlayerColors();
            return currentplayer;
        }

        private void setPlayerColors()
        {
            if (currentplayer == player1)
            {
                lblPlayer1Name.ForeColor = Color.Red;
                lblPlayer2Name.ForeColor = Color.Black;
                lblPlayer3Name.ForeColor = Color.Black;
            }
            else if (currentplayer == player2)
            {
                lblPlayer1Name.ForeColor = Color.Black;
                lblPlayer2Name.ForeColor = Color.Red;
                lblPlayer3Name.ForeColor = Color.Black;
            }
            else if (currentplayer == player3)
            {
                lblPlayer1Name.ForeColor = Color.Black;
                lblPlayer2Name.ForeColor = Color.Black;
                lblPlayer3Name.ForeColor = Color.Red;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            switch (game.step)
            {
                case 1:
                    step1();
                    break;
                case 2:
                    step2();
                    break;
                case 3:
                    step3();
                    break;
            }

            if (secretWord.value > 0 && secretWord.value == secretWord.size)
            {
                currentplayer.guessedWord = true;
                secretWord.value = 0;
            }

            if (currentplayer.guessedWord)
            {
                gameTimer.Stop();

                if (DialogResult.Yes == MessageBox.Show(currentplayer.name + " wins! You have won $" + currentplayer.points + ". Play Again? ", "Alert"
                              , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
                currentplayer.guessedWord = false;
            }
            if (false && player2.guessedWord)
            {
                gameTimer.Stop();

                if (DialogResult.Yes == MessageBox.Show(player2.name + " wins! You have won $" + player2.points + ". Play Again? ", "Alert"
                              , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
                player2.guessedWord = false;
            }
            if (false && player3.guessedWord)
            {
                gameTimer.Stop();

                if (DialogResult.Yes == MessageBox.Show(player3.name + " wins! You have won $" + player3.points + ". Play Again? ", "Alert"
                              , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
                player3.guessedWord = false;
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
                if (currentplayer.points < 125)
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
                if (vowel[i].IsAccessible && currentplayer.points >= 125 && game.step > 1)
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
            Properties.Settings.Default.Player1Name = player1.name;
            Properties.Settings.Default.Player2Name = player2.name;
            Properties.Settings.Default.Player3Name = player3.name;
            Properties.Settings.Default.Player1Points = player1.points;
            Properties.Settings.Default.Player2Points = player2.points;
            Properties.Settings.Default.Player3Points = player3.points;
            Properties.Settings.Default.StartingPlayerName = currentplayer.name;
            Properties.Settings.Default.Save();
        }
    }
}
