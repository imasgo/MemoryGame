using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory
{
    public partial class Form1 : Form
    {
        //Variables
        

        //For going back to menu

        int tmrst;
        int score = 0;//score
        MenuForm mf = new MenuForm();

        //Random choice of location
        Random Location = new Random();//Chooses random places for each new card
        
        //Location list
        //List<int> X = new List<int>();//list of x coordinates
        //List<int> Y = new List<int>();//list of y coordinates
        int timerset;

        List<Point> Points = new List<Point>();


        List<int> check = new List<int>();
        int timercount;
        
        //for checking does they match
        PictureBox PendingImage1;

        PictureBox PendingImage2;


        public Form1(string str)
        {
            InitializeComponent();
            //for difficulty level
            label4.Text = str;
        }
           

       

    
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //5 seconds to remember
            label1.Text = "5";

            //Getting difficulty level
            string str = label4.Text;

            switch (str)
            {
                case "Easy":
                    label3.Text = "90";
                    break;
                case "Medium":
                    label3.Text = "60";
                    break;
                case "Hard":
                    label3.Text = "40";
                    break;

            }
            tmrst = int.Parse(label3.Text);

            //if (label4.Text == "Medium")
            //{
            //    label3.Text = "40"; //заменить переменной
            //}

            //Updating score
            ScoreCount.Text = "0";

            //randomize
            foreach (PictureBox pic in panel1.Controls)
            {
                pic.Enabled = false;
                Points.Add(pic.Location);
            }

            foreach (PictureBox pic in panel1.Controls)
            {
                int nxt = Location.Next(Points.Count);
                Point pnt = Points[nxt];
                pic.Location = pnt;
                Points.Remove(pnt);
            }

            //timers, for 5 seconds
            timer2.Start();
            timer1.Start();

            //Upoading pictures to objects for first five seconds
            Pic1.Image = Properties.Resources.Picture1;
            Pic1Dup.Image = Properties.Resources.Picture1;
            Pic2.Image = Properties.Resources.Picture2;
            Pic2Dup.Image = Properties.Resources.Picture2;
            Pic3.Image = Properties.Resources.Picture3;
            Pic3Dup.Image = Properties.Resources.Picture3;
            Pic4.Image = Properties.Resources.Picture4;
            Pic4Dup.Image = Properties.Resources.Picture4;
            Pic5.Image = Properties.Resources.Picture5;
            Pic5Dup.Image = Properties.Resources.Picture5;
            Pic6.Image = Properties.Resources.Picture6;
            Pic6Dup.Image = Properties.Resources.Picture6;
            Pic7.Image = Properties.Resources.Picture7;
            Pic7Dup.Image = Properties.Resources.Picture7;
            Pic8.Image = Properties.Resources.Picture8;
            Pic8Dup.Image = Properties.Resources.Picture8;
            Pic9.Image = Properties.Resources.Picture9;
            Pic9Dup.Image = Properties.Resources.Picture9;
            Pic10.Image = Properties.Resources.Picture10;
            Pic10Dup.Image = Properties.Resources.Picture10;
            Pic11.Image = Properties.Resources.Picture11;
            Pic11Dup.Image = Properties.Resources.Picture11;
            Pic12.Image = Properties.Resources.Picture12;
            Pic12Dup.Image = Properties.Resources.Picture12;

        }

        //event for ticking
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox pic in panel1.Controls)
            {
                pic.Enabled = true;
                pic.Cursor = Cursors.Hand;
                pic.Image = Properties.Resources.CoverPicture;
            }
        }

        //another event for ticking
        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer-1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
                TimeLimit.Start();
        }
        }

        //One method for clicking picture boxes
        private void PicClick(object sender, EventArgs e)
        {

            var pic = (PictureBox)sender;
            string s = pic.Tag.ToString()+".png";
            

            
            string path = "C:/Users/Dima/Source/Repos/MemoryGame/GameMemory/Resources/Picture" + s;
            pic.Image = Image.FromFile(path);


            if (PendingImage1 == null)
            {
                PendingImage1 = pic;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = pic;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if ((PendingImage1.Tag == PendingImage2.Tag) && (PendingImage1.Location!=PendingImage2.Location))
                {
                    
                    PendingImage1 = null;
                    PendingImage2 = null;

                    pic.Enabled = false;

                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }




        //timer 3 for 40,60,90 seconds
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.CoverPicture;
            PendingImage2.Image = Properties.Resources.CoverPicture;
            PendingImage1 = null;
            PendingImage2 = null;

        }


        //getting back to menu
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
            e.Cancel = true;
            mf.Show();   
        }

        //another way to getting back 
        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            mf.Show();
        }


        //
        private void TimeLimit_Tick(object sender, EventArgs e)
        {
            //label --
            int timeleft = Convert.ToInt32(label3.Text);
            timeleft = timeleft - 1;
            label3.Text = Convert.ToString(timeleft);

            //for entering your name and getting back to meno
            Username lform = new Username();
            MenuForm lform1 = new MenuForm();

            //getting score
            score = Convert.ToInt32(ScoreCount.Text);

            //ending
            if((score == 120)||(timeleft==0))
            {
                TimeLimit.Stop();
                if (timeleft == 0)
                {
                    MessageBox.Show("You lose!");
                    this.Hide();
                    lform1.Show();
                   
                }
                else
                {
                    //writing to db and going to username
                    this.Hide();
                    lform.Show();
                    lform.Username_Load(sender,e);

                    using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:/Users/Мария/Documents/Visual Studio 2015/Projects/GameMemory/DbDataGame.txt", true))
                    {

                        int gametime = tmrst - timeleft;
                        file.Write(gametime.ToString()+",");
                            
                    }
                   

                }
                
                
            }

        }

        private void ScoreCount_Click(object sender, EventArgs e)
        {

        }
    }
}
