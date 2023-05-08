using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Cappybara_Love : Form
    {
        
        string[] message = { "Hello Chinchilla, Did you know that this cappybara loves you??", "Take a break, message the love of your life", "smooch time?", "click me for a surprise" };
        string[] pain = { "YOU STABBED ME!", "AAHHHH", "Why do you cause me this pain", "I'm in agony!", "My spleen!", "Guah! It hurts, tell my wife I love her", "Please no Jessica, I don't have your money!", "Hit me all you want, just dont hurt my kids, PLEASE!" };
       
       private  Random randomX = new Random();
       private  Random randomY = new Random();
        private Random Message = new Random();
        int walkRX = 1;
        int WalkRY = 1;
        int pains = 0;

        int x = 0; 
        int y = 0;

       

        
        public Cappybara_Love()
        {
            InitializeComponent();

        }

        private void Cappybara_Love_Load(object sender, EventArgs e)
        {
            
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            cappyleft.Hide();
            textRight.Show();
            dedcappy.Hide();
            textRight.Text = "Hello my love, welcome to your very own personal application Click me to close this box";
            this.TopMost = true;
           
           Tmessage.Start();
           Twalk.Start();
        }
 


 

        private void messagereader()
        {
            textRight.Show();
            Random random = new Random();
            string output = message[random.Next(4)];
            textRight.Text = output;
        }

        
        private void cappyright_Click(object sender, EventArgs e)
        {
            textRight.Show();
            textRight.Text = pain[Message.Next(pain.Length)];
            pains++;
            if (pains == 15)
            {
                dedcappy.Show();
                cappyleft.Hide();
                cappyright.Hide();
                respawn.Start();
                Twalk.Stop();
                Tmessage.Stop();
                pains = 0;

            }
        }
        private void cappyleft_Click(object sender, EventArgs e)
        {
            textRight.Show();
            textRight.Text = pain[Message.Next(pain.Length)];
            pains++;
            if (pains == 15)
            {
                dedcappy.Show();
                cappyleft.Hide();
                cappyright.Hide();
                respawn.Start();
                Twalk.Stop();
                Tmessage.Stop();
                pains = 0;
            }
        }


        private void Trandomizer_Tick(object sender, EventArgs e)
        {
             walkRX = randomX.Next(2450);
             WalkRY = randomY.Next(850);
        }
        private void Twalk_Tick(object sender, EventArgs e)
        {
            
            
            if (x > walkRX)
            {
                cappyright.Hide();
                cappyleft.Show();
               x--;
               
                Location = new Point(x, y);
            }
            if (y > WalkRY)
            {
                cappyright.Hide();
                cappyleft.Show();
                y--;
                
                Location = new Point(x, y);
            }
            if (x < walkRX)
            {
                cappyleft.Hide();
                cappyright.Show();
               x++;
               
                Location = new Point(x, y);
            }
            if (y < WalkRY)
            {
                cappyleft.Hide();
                cappyright.Show();
               y++;
               
                Location = new Point(x, y);
            }
            if (x == walkRX && y == WalkRY)
            {
                randomizer();
            }
            
        }


        //Randomizes co-ordinates
        void randomizer()
        {
             walkRX = randomX.Next(2450);
             WalkRY = randomY.Next(850);
        }


        //after a tick will call upon the message reader
        private void Tmessage_Tick(object sender, EventArgs e)
        {
            messagereader();
            if(Tmessage.Interval == 3000)
            {
                textRight.Hide();
                textRight.Text = "";
            }
        }

        //resets the text box
        private void TmessageStop_Tick(object sender, EventArgs e)
        {
            textRight.Hide();
            textRight.Text = "";
        }

        //respawns the cappy after a time
        private void respawn_Tick(object sender, EventArgs e)
        {
            textRight.Show();
            textRight.Text = "I'M ALIVE! but the pain lingers";
            respawn.Stop();
            Twalk.Start();
            Tmessage.Start();
            dedcappy.Hide();
            
        }

        //shows a message after ded cappy is clicked
        private void dedcappy_Click(object sender, EventArgs e)
        {
            textRight.Show();
            textRight.Text = "*pokes*";
        }
    }
}
