using System;
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
        int score = 0;//score
        bool again = false;//Do you want to play again
        Random Location = new Random();//Chooses random places for each new card
        List<int> X = new List<int>();//list of x coordinates
        List<int> Y = new List<int>();//list of y coordinates
        List<int> check = new List<int>();
        PictureBox PendingImage1;
        PictureBox PendingImage2;
        public Form1()
        {
            InitializeComponent();
        }
        // i like u
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (PictureBox pic in panel1.Controls)
            {
                pic.Enabled = false;
            }
            timer2.Start();
            timer1.Start();
            Pic1.Image = Properties.Resources.Card1;
            Pic1Dup.Image = Properties.Resources.Card1;
            Pic2.Image = Properties.Resources.Card2;
            Pic2Dup.Image = Properties.Resources.Card2;
            Pic3.Image = Properties.Resources.Card3;
            Pic3Dup.Image = Properties.Resources.Card3;
            Pic4.Image = Properties.Resources.Card4;
            Pic4Dup.Image = Properties.Resources.Card4;
            Pic5.Image = Properties.Resources.Card5;
            Pic5Dup.Image = Properties.Resources.Card5;
            Pic6.Image = Properties.Resources.Card6;
            Pic6Dup.Image = Properties.Resources.Card6;
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
                pic.Image = Properties.Resources.MdzRlewvieo1;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer-1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0) { timer2.Stop(); }
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

                }
                else
                {
                    timer3.Start();
                }
            }
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.MdzRlewvieo1;
            PendingImage2.Image = Properties.Resources.MdzRlewvieo1;
            PendingImage1 = null;
            PendingImage2 = null;
        }
    }
}
