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

        public Form1()
        {
            rand = new Random();
            wordIndex = rand.Next(0, words.Length);
            wheelofFortune = new Wheel();
            secretWord = new SecretWord(words[wordIndex]);
            word = new Word[secretWord.size];
            player1 = new Player("player");
            wheelIsMoved = false;
            wheelTimes = 100;
            InitializeComponent();
            drawSecretWord();
            wheelTimer = new Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += wheelTimer_Tick;
            

            button = new Button[26];
            vowel = new Button[6];
            consonant = new Button[20];

            button[0] = button1;
            button[1] = button3;
            button[2] = button4;
            button[3] = button6;
            button[4] = button7;
            button[5] = button9;
            button[6] = button10;
            button[7] = button11;
            button[8] = button12;
            button[9] = button13;
            button[10] = button14;
            button[11] = button15;
            button[12] = button17;
            button[13] = button18;
            button[14] = button20;
            button[15] = button22;
            button[16] = button23;
            button[17] = button24;
            button[18] = button25;
            button[19] = button27;
            button[20] = button28;
            button[21] = button29;
            button[22] = button30;
            button[23] = button31;
            button[24] = button32;
            button[25] = button33;

            vowel[0] = button1;
            vowel[1] = button7;
            vowel[2] = button12;
            vowel[3] = button20;
            vowel[4] = button28;
            vowel[5] = button32;



            consonant[0] = button3;
            consonant[1] = button4;
            consonant[2] = button6;
            consonant[3] = button9;
            consonant[4] = button10;
            consonant[5] = button11;
            consonant[6] = button13;
            consonant[7] = button14;
            consonant[8] = button15;
            consonant[9] = button17;
            consonant[10] = button18;
            consonant[11] = button22;
            consonant[12] = button23;
            consonant[13] = button24;
            consonant[14] = button25;
            consonant[15] = button27;
            consonant[16] = button29;
            consonant[17] = button30;
            consonant[18] = button31;
            consonant[19] = button33;

            for (int i = 0; i < 25; i++ )
            {
                button[i].IsAccessible = true;    //already chosen
                button[i].Enabled = true;         //active flag
                button[i].Visible = false;        //visibility flag
            }

            game = new Game();

            gameTimer = new Timer();
            gameTimer.Interval = 100;
            gameTimer.Tick += gameTimer_Tick;
            label4.Text = game.hint[0];

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
            for(int i=0; i<secretWord.size; i++ )
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
                        || chosenButton.Text.Equals("Y") )
                    {
                        player1.points -= 300;
                        label6.Text = "$" + Convert.ToString(player1.points);
                    }
                    else
                    {
                        game.guessedLetter += 1;
                        player1.points += game.rate;
                        label6.Text = "$" + Convert.ToString(player1.points);
                        game.step = 3;
                    }

                    ifExist = true;
                    secretWord.value++;
                }
            }

            if( !ifExist )
            {
                label4.Text = game.hint[4];
                game.guessedLetter = 0;
                game.step = 1;
            }

        }
        
        public Bitmap rotateImage()
        {
            Bitmap rotatedImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((pictureBox1.Width / 2), pictureBox1.Height / 2); //set the rotation point as the center into the matrix
                g.RotateTransform(wheelofFortune.angle); //rotate
                g.TranslateTransform(-pictureBox1.Width / 2, -pictureBox1.Height / 2); //restore rotation point into the matrix
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
            label4.Visible = false;

            if (wheelIsMoved && wheelTimes > 0)
            {
                wheelofFortune.angle += wheelTimes/10;
                wheelofFortune.angle = wheelofFortune.angle % 360;
                RotateImage(pictureBox1, wheelofFortune.picture, wheelofFortune.angle);
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

            label1.Text = Convert.ToString(wheelofFortune.angle);
            label2.Text = Convert.ToString(wheelofFortune.state);
            label3.Text = Convert.ToString(wheelofFortune.wheelState[wheelofFortune.state]);

            game.rate = wheelofFortune.wheelState[wheelofFortune.state];
            game.hint[2] = "Playing for $" + game.rate + ".";

            if (wheelTimes == 0)
            {
                wheelIsMoved = false;

                for (int i = 0; i < button.Length;i++ )
                {
                    if (button[i].IsAccessible)
                    {
                        button[i].Visible = true;
                    }
                }

                if(wheelofFortune.wheelState[wheelofFortune.state] == 0)
                {
                    player1.points = 0;
                    game.step = 1;
                }
                else
                {
                    game.step = 2;
                }

                wheelTimer.Stop();
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
                    etap3();
                    break;
            }

            if(secretWord.value>0 && secretWord.value == secretWord.size)
            {
                player1.guessedWord = true;
                secretWord.value =0;
            }

            if(player1.guessedWord)
            {
                gameTimer.Stop();

                if (DialogResult.OK == MessageBox.Show("You Win! You have won $" + player1.points + ". Play Again? ", "Alert"
                              , MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
                player1.guessedWord = false;

            }

        }

        public void step1()
        {
            label4.Visible = true;
            
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            for (int i = 0; i < button.Length; i++)
            {
                button[i].Visible = false;
            }

        }

        public void step2()
        {
            label4.Visible = true;
            label4.Text = game.hint[2];
            pictureBox1.Click -= new System.EventHandler(this.pictureBox1_Click);


                    for (int i = 0; i < vowel.Length; i++)
                    {
                         if (vowel[i].IsAccessible)
                         {
                             vowel[i].Enabled = false;
                         }
                    
                    } 


            for (int i = 0; i < consonant.Length; i++)
            {
                if(consonant[i].IsAccessible)
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

        public void etap3()
        {
            label4.Text = game.hint[1];
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            for (int i = 0; i < consonant.Length; i++) consonant[i].Enabled = false;


            if (player1.points >= 300)
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
