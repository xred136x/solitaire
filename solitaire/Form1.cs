using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace solitaire
{
    public partial class Form1 : Form
    {
        int count = 0;
        string suit = null;
        string val = null;
        string suit2 = null;
        string val2 = null;
        Point tmp;
        PictureBox pbs = null;
        PictureBox pbs2 = null;
        int pointGamer1 = 0;
        int pointGamer2 = 0;
        int queue = 0;
        static Random rand2 = new Random();
        PictureBox[] pictureBoxes = new PictureBox[36]; 
        public Form1()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[] {pB1, pB2, pB3, pB4, pB5, pB6, pB7, pB8, pB9,
            pB10, pB11, pB12, pB13, pB14, pB15, pB16, pB17, pB18, pB19, pB20, pB21, pB22, pB23, pB24,
            pB25, pB26, pB27, pB28, pB29, pB30, pB31, pB32, pB33, pB34, pB35, pB36};
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (rB2.Checked)
            {
                if (queue > 0 && pointGamer2 > pointGamer1) MessageBox.Show("Игрок2 WIN!!!");
                if (queue > 0 && pointGamer2 < pointGamer1) MessageBox.Show("Игрок1 WIN!!!");
            }
                       
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Visible = true;
                pictureBoxes[i].Image = Image.FromFile(@"Карты\рубашка.jpg");             
                int b = rand2.Next(0, pictureBoxes.Length);
                tmp = pictureBoxes[i].Location;
                pictureBoxes[i].Location = pictureBoxes[b].Location;
                pictureBoxes[b].Location = tmp;
            }
            suit = null;
            val = null;
            suit2 = null;
            val2 = null;
            pointGamer1 = 0; pointGamer2 = 0;            
            queue = 0;
            pbs = null; pbs2 = null;
            label2.Text = pointGamer1.ToString();
            label3.Text = pointGamer2.ToString();
        }

        private void Comparison()
        {
            queue++;
            if (rB2.Checked)
            {
                if (queue % 2 == 0) label1.Text = "Ход первого игрока";
                else label1.Text = "Ход второго игрока";
            }
            pbs2.Image = Image.FromFile(@"Карты\рубашка.jpg");
            if(val+suit != val2+suit2)
            if (val == val2 || suit ==  suit2)
            {              
                pbs.Visible = false;
                pbs2.Visible = false;                
                    if(rB1.Checked)
                    {
                        pointGamer1++;
                        label2.Text = pointGamer1.ToString();
                        if(pointGamer1 == 18) MessageBox.Show("YOU WIN!!!");
                    }
                    if (rB2.Checked)
                    {
                        if (queue % 2 == 0)
                        {                            
                            pointGamer2++;
                            label3.Text = pointGamer2.ToString();
                        }
                        else
                        {                            
                            pointGamer1++;
                            label2.Text = pointGamer1.ToString();
                        }
                        if (count == 4 && pointGamer2 > pointGamer1) MessageBox.Show("Игрок2 WIN!!!");
                        if (count == 4 && pointGamer2 < pointGamer1) MessageBox.Show("Игрок1 WIN!!!");
                        if (pointGamer1 + pointGamer2 == 18 && pointGamer2 > pointGamer1) MessageBox.Show("Игрок2 WIN!!!");
                        if (pointGamer1 + pointGamer2 == 18 && pointGamer2 < pointGamer1) MessageBox.Show("Игрок1 WIN!!!");
                        if (pointGamer1 + pointGamer2 >=16) { count++; }
                    }
            }
            


        }
        private void Pause()
        {
            Thread.Sleep(1000);
        }
        private void pB1_Click(object sender, EventArgs e)
        {
            
         
            pB1.Image = Image.FromFile(@"Карты\6 буби.png");
                        
            if(pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB1;
                val2 = "6";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB1;
                val = "6";
                suit = "буби";
            }
        }

        private void pB2_Click(object sender, EventArgs e)
        {
           
           
            pB2.Image = Image.FromFile(@"Карты\7 буби.jpg");
            
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB2;
                val2 = "7";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB2;
                val = "7";
                suit = "буби";
            }

        }

        private void pB3_Click(object sender, EventArgs e)
        {
            
          
            pB3.Image = Image.FromFile(@"Карты\8 буби.png");
            
            if (pbs != null)
            {
                
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB3;
                val2 = "8";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB3;
                val = "8";
                suit = "буби";
            }

        }

        private void pB4_Click(object sender, EventArgs e)
        {
            
           
            pB4.Image = Image.FromFile(@"Карты\9 буби.png");
           
            if (pbs != null)
            { 
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB4;
                val2 = "9";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB4;
                val = "9";
                suit = "буби";
            }
        }

        private void pB5_Click(object sender, EventArgs e)
        {
            
          
            pB5.Image = Image.FromFile(@"Карты\10 буби.png");
            
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB5;
                val2 = "10";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB5;
                val = "10";
                suit = "буби";
            }


        }

        private void pB6_Click(object sender, EventArgs e)
        {
            
            
            pB6.Image = Image.FromFile(@"Карты\валет буби.png");
            
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB6;
                val2 = "валет";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB6;
                val = "валет";
                suit = "буби";
            }
        }

        private void pB7_Click(object sender, EventArgs e)
        {
            
          
            pB7.Image = Image.FromFile(@"Карты\дама буби.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB7;
                val2 = "дама";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB7;
                val = "дама";
                suit = "буби";
            }
        }

        private void pB8_Click(object sender, EventArgs e)
        {
           
            pB8.Image = Image.FromFile(@"Карты\король буби.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB8;
                val2 = "король";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB8;
                val = "король";
                suit = "буби";
            }
        }

        private void pB9_Click(object sender, EventArgs e)
        {
           
            pB9.Image = Image.FromFile(@"Карты\туз буби.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB9;
                val2 = "туз";
                suit2 = "буби";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB9;
                val = "туз";
                suit = "буби";
            }
        }

        private void pB10_Click(object sender, EventArgs e)
        {
           
            pB10.Image = Image.FromFile(@"Карты\6 черви.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB10;
                val2 = "6";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB10;
                val = "6";
                suit = "черви";
            }
        }

        private void pB11_Click(object sender, EventArgs e)
        {
           
            pB11.Image = Image.FromFile(@"Карты\7 черви.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB11;
                val2 = "7";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB11;
                val = "7";
                suit = "черви";
            }
        }

        private void pB12_Click(object sender, EventArgs e)
        {
            
            pB12.Image = Image.FromFile(@"Карты\8 черви.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB12;
                val2 = "8";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB12;
                val = "8";
                suit = "черви";
            }
        }

        private void pB13_Click(object sender, EventArgs e)
        {
           
            pB13.Image = Image.FromFile(@"Карты\9 черви.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB13;
                val2 = "9";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB13;
                val = "9";
                suit = "черви";
            }
        }

        private void pB14_Click(object sender, EventArgs e)
        {
           
            pB14.Image = Image.FromFile(@"Карты\10 черви.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB14;
                val2 = "10";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB14;
                val = "10";
                suit = "черви";
            }
        }

        private void pB15_Click(object sender, EventArgs e)
        {
            
            pB15.Image = Image.FromFile(@"Карты\валет черви.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB15;
                val2 = "валет";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB15;
                val = "валет";
                suit = "черви";
            }
        }

        private void pB16_Click(object sender, EventArgs e)
        {
           
            pB16.Image = Image.FromFile(@"Карты\дама черви.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB16;
                val2 = "дама";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB16;
                val = "дама";
                suit = "черви";
            }
        }

        private void pB17_Click(object sender, EventArgs e)
        {

            pB17.Image = Image.FromFile(@"Карты\король черви.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB17;
                val2 = "король";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB17;
                val = "король";
                suit = "черви";
            }
        }

        private void pB18_Click(object sender, EventArgs e)
        {
           
            pB18.Image = Image.FromFile(@"Карты\туз черви.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB18;
                val2 = "туз";
                suit2 = "черви";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB18;
                val = "туз";
                suit = "черви";
            }
        }

        private void pB19_Click(object sender, EventArgs e)
        {
           
            pB19.Image = Image.FromFile(@"Карты\6 крести.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB19;
                val2 = "6";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB19;
                val = "6";
                suit = "крести";
            }
        }

        private void pB20_Click(object sender, EventArgs e)
        {
          
            pB20.Image = Image.FromFile(@"Карты\7 крести.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB20;
                val2 = "7";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB20;
                val = "7";
                suit = "крести";
            }
        }

        private void pB21_Click(object sender, EventArgs e)
        {
           
            pB21.Image = Image.FromFile(@"Карты\8 крести.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB21;
                val2 = "8";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB21;
                val = "8";
                suit = "крести";
            }
        }

        private void pB22_Click(object sender, EventArgs e)
        {
            
            pB22.Image = Image.FromFile(@"Карты\9 крести.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB22;
                val2 = "9";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB22;
                val = "9";
                suit = "крести";
            }
        }

        private void pB23_Click(object sender, EventArgs e)
        {
            
            pB23.Image = Image.FromFile(@"Карты\10 крести.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB23;
                val2 = "10";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB23;
                val = "10";
                suit = "крести";
            }
        }

        private void pB24_Click(object sender, EventArgs e)
        {
          
            pB24.Image = Image.FromFile(@"Карты\валет крести.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB24;
                val2 = "валет";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB24;
                val = "валет";
                suit = "крести";
            }

        }

        private void pB25_Click(object sender, EventArgs e)
        {
            
            pB25.Image = Image.FromFile(@"Карты\дама крести.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB25;
                val2 = "дама";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB25;
                val = "дама";
                suit = "крести";
            }
        }

        private void pB26_Click(object sender, EventArgs e)
        {
            
            pB26.Image = Image.FromFile(@"Карты\король крести.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB26;
                val2 = "король";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB26;
                val = "король";
                suit = "крести";
            }
        }

        private void pB27_Click(object sender, EventArgs e)
        {
            
            pB27.Image = Image.FromFile(@"Карты\туз крести.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB27;
                val2 = "туз";
                suit2 = "крести";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB27;
                val = "туз";
                suit = "крести";
            }
        }

        private void pB28_Click(object sender, EventArgs e)
        {
           
            pB28.Image = Image.FromFile(@"Карты\6 пики.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB28;
                val2 = "6";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB28;
                val = "6";
                suit = "пики";
            }
        }

        private void pB29_Click(object sender, EventArgs e)
        {
           
            pB29.Image = Image.FromFile(@"Карты\7 пики.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB29;
                val2 = "7";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB29;
                val = "7";
                suit = "пики";
            }
        }
        private void pB30_Click(object sender, EventArgs e)
        {
            
            pB30.Image = Image.FromFile(@"Карты\8 пики.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB30;
                val2 = "8";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB30;
                val = "8";
                suit = "пики";
            }
        }
        private void pB31_Click(object sender, EventArgs e)
        {
            
            pB31.Image = Image.FromFile(@"Карты\9 пики.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB31;
                val2 = "9";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB31;
                val = "9";
                suit = "пики";
            }
        }

        private void pB32_Click(object sender, EventArgs e)
        {
           
            pB32.Image = Image.FromFile(@"Карты\10 пики.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB32;
                val2 = "10";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB32;
                val = "10";
                suit = "пики";
            }
        }

        private void pB33_Click(object sender, EventArgs e)
        {
            
            pB33.Image = Image.FromFile(@"Карты\валет пики.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB33;
                val2 = "валет";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB33;
                val = "валет";
                suit = "пики";
            }
        }

        private void pB34_Click(object sender, EventArgs e)
        {
           
            pB34.Image = Image.FromFile(@"Карты\дама пики.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB34;
                val2 = "дама";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB34;
                val = "дама";
                suit = "пики";
            }
        }

        private void pB35_Click(object sender, EventArgs e)
        {
            
            pB35.Image = Image.FromFile(@"Карты\король пики.jpg");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB35;
                val2 = "король";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB35;
                val = "король";
                suit = "пики";
            }
        }

        private void pB36_Click(object sender, EventArgs e)
        {
           
            pB36.Image = Image.FromFile(@"Карты\туз пики.png");
            if (pbs != null)
            {
                pbs.Image = Image.FromFile(@"Карты\рубашка.jpg");
                pbs2 = pB36;
                val2 = "туз";
                suit2 = "пики";
                Comparison();
                pbs = null;
                val = null;
                suit = null;
            }
            else
            {
                pbs = pB36;
                val = "туз";
                suit = "пики";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            foreach (PictureBox picture in pictureBoxes)
            {
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
