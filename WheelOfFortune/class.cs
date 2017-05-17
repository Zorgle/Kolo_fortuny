using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public class Word : System.Windows.Forms.TextBox
    {
        public Word()
        {
            this.Width = 40;
            this.Height = 40;
            this.BackColor = Color.White;
            this.Font = new Font("Georgia", 16);
            this.TextAlign = HorizontalAlignment.Center;
            this.ReadOnly = true;
            this.Enabled = false;
            this.UseSystemPasswordChar = true;
            this.ForeColor = Color.Black;
            this.Visible = true;
        }
    }

    public class SecretWord
    {
        public int size;
        public string password;
        public Word[] field;
        public int value;

        public SecretWord()
        {
            size = 0;
            field = new Word[password.Length];
            password = "0";
            value = 0;
        }

        public SecretWord(string s)
        {
            field = new Word[s.Length];
            size = s.Length;
            password = s;
            int y = 120;
            int x = 0;
            for (int i = 0; i < field.Length; i++)
            {
                if (Convert.ToString(password[i]) == " ")
                {
                    y = y + 120;
                    x = 0;
                }
                x++;
                field[i] = new Word();
                field[i].Name = "Letter " + i;
                field[i].Location = new Point(60 * x + 80, y);
                field[i].Text = Convert.ToString(password[i]);
            }
        }
    }   
    
    public class Wheel
    {
        public Bitmap picture;
        public Bitmap tempPicture;
        public float angle;
        public int[] wheelState;
        public int state;

        public Wheel()
        {
            tempPicture = new Bitmap(Properties.Resources.wheel);
            picture = new Bitmap(Properties.Resources.wheel);        
            wheelState = new int[] { 425, 225, 375, -1, 25, 275, 400, 325, 100, 0, 200, 50, 350, 3000, 175, 475, 300, 125, 75, 500};
            angle = 0.0f;
        }

    }

    class Player
    {
        public String name;
        public int points;
        public bool guessedWord;


        public Player(string i)
        {
            name = i;
            points = 0;
            guessedWord = false;
        }
    }

    class Game
    {
        public int step;
        public bool gameEnd;
        public string[] hint;
        public int guessedLetter;
        public int rate;

        public Game()
        {
            step = 1;
            gameEnd = false;
            guessedLetter = 0;
            rate = 0;
            hint = new string[] {"Click the wheel to spin." ,"Buy a vowel or spin the wheel.", "Play for $" + rate, "Bankrupt. You've lost everything!", "That letter is not in the word.", "Lose a Turn!"};
        }

        public void statusCheck()
        {
            
        }
    }

}



