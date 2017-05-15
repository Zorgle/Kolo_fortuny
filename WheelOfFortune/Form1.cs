using System;
using System.Drawing;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public partial class Form1 : Form
    {
        SecretWord secretWord;
        Word[] word;
        Wheel wheelofFortune;
        bool wheelIsMoved;
        float startWheelTimes;
        float wheelTimes;
        Timer gameTimer;
        Timer wheelTimer;
        Button[] button;
        Button[] vowel;
        Button[] consonant;
        String[] words = { "BANANA", "APPLE", "WATERMELON", "SQUASH", "WORDS" };
        Random rand;
        int wordIndex;

        Game game;
        Player player1;
        Player player2;
        Player player3;
        Player currentplayer;

        public Form1()
        {
            rand = new Random();
            wordIndex = rand.Next(0, words.Length);
            wheelofFortune = new Wheel();
            secretWord = new SecretWord(words[wordIndex]);
            word = new Word[secretWord.size];
            player1 = new Player("Player1");
            player2 = new Player("Player2");
            player3 = new Player("Player3");
            currentplayer = player1;
            wheelIsMoved = false;
            wheelTimes = 100;
            InitializeComponent();
            drawSecretWord();
            wheelTimer = new Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += wheelTimer_Tick;
            lblPlayer1Name.Text = player1.name;
            lblPlayer1Name.ForeColor = Color.Red;
            lblPlayer2Name.Text = player2.name;
            lblPlayer3Name.Text = player3.name;


            button = new Button[26];
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

            for (int i = 0; i < 25; i++)
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void handleButton(object sender, EventArgs e)
        {
            Boolean ifExist = false;
            Button chosenButton = (Button)sender;
            for (int i = 0; i < secretWord.size; i++)
            {
                if ((secretWord.field[i].Text).Equals((chosenButton.Text)))
                {
                    secretWord.field[i].UseSystemPasswordChar = false;
                    chosenButton.IsAccessible = false;

                    if (chosenButton.Text.Equals("A")
                        || chosenButton.Text.Equals("E")
                        || chosenButton.Text.Equals("I")
                        || chosenButton.Text.Equals("O")
                        || chosenButton.Text.Equals("U")
                        || chosenButton.Text.Equals("Y"))
                    {
                        currentplayer.points -= 300;
                        if(currentplayer == player1)
                        {
                            lblScore1.Text = "$" + Convert.ToString(currentplayer.points);
                            lblPlayer1Name.ForeColor = Color.Red;
                            lblPlayer2Name.ForeColor = Color.Black;
                            lblPlayer3Name.ForeColor = Color.Black;
                        }
                        else if (currentplayer == player2)
                        {
                            lblScore2.Text = "$" + Convert.ToString(currentplayer.points);
                            lblPlayer1Name.ForeColor = Color.Black;
                            lblPlayer2Name.ForeColor = Color.Red;
                            lblPlayer3Name.ForeColor = Color.Black;
                        }
                        else if (currentplayer == player3)
                        {
                            lblScore3.Text = "$" + Convert.ToString(currentplayer.points);
                            lblPlayer1Name.ForeColor = Color.Black;
                            lblPlayer2Name.ForeColor = Color.Black;
                            lblPlayer3Name.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        game.guessedLetter += 1;
                        currentplayer.points += game.rate;
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
                        game.step = 3;
                    }

                    ifExist = true;
                    secretWord.value++;
                }
            }

            if (!ifExist)
            {
                lblInfo.Text = game.hint[4];
                game.guessedLetter = 0;
                game.step = 1;
                incrementPlayer(currentplayer);
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

            game.rate = wheelofFortune.wheelState[wheelofFortune.state];
            game.hint[2] = "Playing for $" + game.rate + ".";

            if (wheelTimes == 0)
            {
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
                    lblInfo.Text = game.hint[3];
                    currentplayer.points = 0;
                    redrawPoints();
                    incrementPlayer(currentplayer);
                    game.step = 1;
                }
                else if (wheelofFortune.wheelState[wheelofFortune.state] == -1)
                {
                    lblInfo.Text = game.hint[5];
                    incrementPlayer(currentplayer);
                    game.step = 1;
                }
                else
                {
                    game.step = 2;
                }

                wheelTimer.Stop();
            }
        }
        private void redrawPoints()
        {
            lblScore1.Text = player1.points.ToString();
            lblScore2.Text = player2.points.ToString();
            lblScore3.Text = player3.points.ToString();
        }

        private Player incrementPlayer(Player passedPlayer)
        {
            if (passedPlayer == player1)
            {
                lblPlayer1Name.ForeColor = Color.Black;
                lblPlayer2Name.ForeColor = Color.Red;
                lblPlayer3Name.ForeColor = Color.Black;
                currentplayer = player2;
                return player2;
            }
            else if (passedPlayer == player2)
            {
                lblPlayer1Name.ForeColor = Color.Black;
                lblPlayer2Name.ForeColor = Color.Black;
                lblPlayer3Name.ForeColor = Color.Red;
                currentplayer = player3;
                return player3;
            }
            else if (passedPlayer == player3)
            {
                lblPlayer1Name.ForeColor = Color.Red;
                lblPlayer2Name.ForeColor = Color.Black;
                lblPlayer3Name.ForeColor = Color.Black;
                currentplayer = player1;
                return player1;
            }
            else
            {
                return player1;
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
            if (player2.guessedWord)
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
            if (player3.guessedWord)
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

            pctWheel.Click += new System.EventHandler(this.pictureBox1_Click);

            for (int i = 0; i < button.Length; i++)
            {
                button[i].Visible = false;
            }

        }

        public void step2()
        {
            lblInfo.Visible = true;
            lblInfo.Text = game.hint[2];
            pctWheel.Click -= new System.EventHandler(this.pictureBox1_Click);

            for (int i = 0; i < vowel.Length; i++)
            {
                if (vowel[i].IsAccessible)
                {
                    vowel[i].Enabled = false;
                }
            }


            for (int i = 0; i < consonant.Length; i++)
            {
                if (consonant[i].IsAccessible)
                {
                    consonant[i].Enabled = true;
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
            pctWheel.Click += new System.EventHandler(this.pictureBox1_Click);

            for (int i = 0; i < consonant.Length; i++) consonant[i].Enabled = false;


            if (currentplayer.points >= 300)
            {
                for (int i = 0; i < vowel.Length; i++) vowel[i].Enabled = true;
            }
            else
            {
                for (int i = 0; i < vowel.Length; i++) vowel[i].Enabled = false;
            }

            for (int i = 0; i < consonant.Length; i++)
            {
                consonant[i].Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
    }
}
