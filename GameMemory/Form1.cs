﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMemory
{
    public partial class Form1 : Form
    {
        //Variables

        int tmrst;
        int score = 0;//score
        MenuForm mf = new MenuForm();
        //bool again = false;//Do you want to play again
        Random Location = new Random();//Chooses random places for each new card
        //List<int> X = new List<int>();//list of x coordinates
        //List<int> Y = new List<int>();//list of y coordinates
        int timerset;

        List<Point> Points = new List<Point>();

        List<int> check = new List<int>();
        int timercount;
        //int timeleft=60;
        PictureBox PendingImage1;

        PictureBox PendingImage2;

        HardLevel hrd;

        public Form1(string str)
        {
            InitializeComponent();
            label4.Text = str;
        }
           

       

    
        // i like u
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "5";
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

            TimeLimit.Start();
            timer2.Start();
            timer1.Start();

            //list of 
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

            //foreach (PictureBox pic in panel1.Controls)
            //{
            //    pic.Image = Properties.Resources.MdzRlewvieo1;
            //}
        }

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer-1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0) { timer2.Stop(); }
        }

        //!!!
        private void PicClick(object sender, EventArgs e)
        {

            var pic = (PictureBox)sender;
            string s = pic.Tag.ToString()+".png";
            
            string path = "C:/Users/Мария/Documents/Visual Studio 2015/Projects/GameMemory/GameMemory/Resources/Picture" + s;
            pic.Image = Image.FromFile(path);

            //Pic1.Image = Properties.Resources.Card1;
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
                    //Pic1.Enabled=false;
                    //Pic1Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        #region Cards Swap
        private void Pic1_Click(object sender, EventArgs e)
        {
            Pic1.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic1;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic1.Enabled = false;
                    Pic1Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        

        }

        private void Pic1Dup_Click(object sender, EventArgs e)
        {
            Pic1Dup.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic1Dup;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic1Dup;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic1.Enabled = false;
                    Pic1Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic2_Click(object sender, EventArgs e)
        {
            Pic2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic2;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic2.Enabled = false;
                    Pic2Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic2Dup_Click(object sender, EventArgs e)
        {
            Pic2Dup.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic2Dup;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic2Dup;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic2.Enabled = false;
                    Pic2Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text)+10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic3_Click(object sender, EventArgs e)
        {
            Pic3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic3;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic3.Enabled = false;
                    Pic3Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic3Dup_Click(object sender, EventArgs e)
        {
            Pic3Dup.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic3Dup;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic3Dup;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic3.Enabled = false;
                    Pic3Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic4_Click(object sender, EventArgs e)
        {
            Pic4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic4;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic4.Enabled = false;
                    Pic4Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic4Dup_Click(object sender, EventArgs e)
        {
            Pic4Dup.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic4Dup;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic4Dup;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic4.Enabled = false;
                    Pic4Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic5_Click(object sender, EventArgs e)
        {
            Pic5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic5;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic5.Enabled = false;
                    Pic5Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic5Dup_Click(object sender, EventArgs e)
        {
            Pic5Dup.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic5Dup;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic5Dup;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic5.Enabled = false;
                    Pic5Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;

                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic6_Click(object sender, EventArgs e)
        {
            Pic6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic6;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic6.Enabled = false;
                    Pic6Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Pic6Dup_Click(object sender, EventArgs e)
        {
            Pic6Dup.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = Pic6Dup;
            }
            else if ((PendingImage1 != null) && (PendingImage2 == null))
            {
                PendingImage2 = Pic6Dup;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Pic6.Enabled = false;
                    Pic6Dup.Enabled = false;
                    ScoreCount.Text = Convert.ToString(Convert.ToInt32(ScoreCount.Text) + 10);
                    score = score + 10;
                }
                else
                {
                    timer3.Start();
                }
            }
        }
        #endregion

        //В int score содержится финальное количество очков!

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.CoverPicture;
            PendingImage2.Image = Properties.Resources.CoverPicture;
            PendingImage1 = null;
            PendingImage2 = null;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Hide();
            e.Cancel = true;
            mf.Show();   
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            mf.Show();
        }

        private void TimeLimit_Tick(object sender, EventArgs e)
        {
            int timeleft = Convert.ToInt32(label3.Text);
            timeleft = timeleft - 1;
            label3.Text = Convert.ToString(timeleft);

            Username lform = new Username();
            MenuForm lform1 = new MenuForm();

            //timercount++;
            //timeleft--;
            //label3.Text = timeleft.ToString();
            score = Convert.ToInt32(ScoreCount.Text);
            if((score == 120)||(timeleft==0))
            {
                TimeLimit.Stop();
                if (timeleft == 0)
                {
                    //MessageBox.Show("I am poppy");
                    this.Hide();
                    lform1.Show();
                   
                }
                else
                {
                    //timerset = int.Parse(label3.Text);
                    this.Hide();
                    lform.Show();
                    lform.Username_Load(sender,e);
                    using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:/Users/Мария/Documents/Visual Studio 2015/Projects/GameMemory/DbDataGame.txt", true))
                    {

                        int gametime = tmrst - timeleft;
                                file.Write(gametime.ToString()+",");
                            
                    }
                    //int gametime1 = 30 - timeleft;
                   // System.IO.File.WriteAllText(@"C:/Users/Мария/Documents/Visual Studio 2015/Projects/GameMemory/DbString.txt", gametime1.ToString() + ",");

                }
                
                //передача в бд
                
            }

        }

        private void ScoreCount_Click(object sender, EventArgs e)
        {

        }
    }
}
