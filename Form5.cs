using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Media;
using System.IO;
using System.Reflection;


namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
           
        }

        public int[] n = { 1, 2, 3 };
        public int[] d = { 4, 5, 6, 7, 8 };
        public Random randomNum = new Random();
        int num=0;
        int dem = 0;
        static SoundPlayer t = new SoundPlayer("sounds/1-4.wav");
        static SoundPlayer t2 = new SoundPlayer("sounds/1-5.wav");
        static SoundPlayer t3 = new SoundPlayer("sounds/1-6.wav");
        static SoundPlayer t4 = new SoundPlayer("sounds/1-7.wav");
            static SoundPlayer t5= new SoundPlayer("sounds/1-8.wav");
            static SoundPlayer t6 = new SoundPlayer("sounds/2-4.wav");
            static SoundPlayer t7 = new SoundPlayer("sounds/2-5.wav");
            static SoundPlayer t8 = new SoundPlayer("sounds/2-6.wav");
            static SoundPlayer t9 = new SoundPlayer("sounds/2-7.wav");
            static SoundPlayer t10 = new SoundPlayer("sounds/2-8.wav");
            static SoundPlayer t11 = new SoundPlayer("sounds/3-4.wav");
            static SoundPlayer t12 = new SoundPlayer("sounds/3-5.wav");
            static SoundPlayer t13 = new SoundPlayer("sounds/3-6.wav");
            static SoundPlayer t14 = new SoundPlayer("sounds/3-7.wav");
            static SoundPlayer t15 = new SoundPlayer("sounds/3-8.wav");
            int count = 0;
       public void represent() {
           
         
               Graphics gr = panel1.CreateGraphics();

               gr.Clear(this.BackColor);
               int ind1 = randomNum.Next(0, 3);
               int ind2 = randomNum.Next(0, 5);
               int num1 = n[ind1];//specify index
               int dem1 = d[ind2];
               switch (num1)
               {
                   case 1: num = 1;
                       if (dem1 == 4)
                       {
                          
                           dem = 4;
                       }
                       else if (dem1 == 5)
                       {
                          
                           dem = 5;
                       }
                       else if (dem1 == 6)
                       {
                          
                           dem = 6;
                       }
                       else if (dem1 == 7)
                       {
                        
                           dem = 7;
                       }
                       else if (dem1 == 8)
                       {
                          
                           dem = 8;
                       }
                       break;
                   case 2: num = 2;
                       if (dem1 == 4)
                       {
                        
                           dem = 4;
                       }
                       else if (dem1 == 5)
                       {
                           
                           dem = 5;
                       }
                       else if (dem1 == 6)
                       {
                          
                           dem = 6;
                       }
                       else if (dem1 == 7)
                       {
                       
                           dem = 7;
                       }
                       else if (dem1 == 8)
                       {
                          
                           dem = 8;
                       }
                       break;
                   case 3: num = 3;
                       if (dem1 == 4)
                       {
                          
                           dem = 4;
                       }
                       else if (dem1 == 5)
                       {
                          
                           dem = 5;
                       }
                       else if (dem1 == 6)
                       {
                          
                           dem = 6;
                       }
                       else if (dem1 == 7)
                       {
                        
                           dem = 7;
                       }
                       else if (dem1 == 8)
                       {
                           
                           dem = 8;
                       }
                       break;
               }

               label2.Text = " " + (num1.ToString()) + "\n____\n" + " " + (dem1.ToString());


               Rectangle r = new Rectangle(1, 1, 120, 120);

               Pen p1 = new Pen(Color.Black, 2);
               SolidBrush fill = new SolidBrush(Color.Orange);

               int sweepAngle = (360 / dem1);

               int startAngle = 0;
               for (int i = 0; i < dem1; i++)
               {


                   gr.DrawPie(p1, r, startAngle, sweepAngle);
                   startAngle = startAngle + sweepAngle;


               }
               startAngle = 0;
               int color = 0;
               while (color < num1)
               {

                   gr.FillPie(fill, r, startAngle, sweepAngle);
                   gr.DrawPie(p1, r, startAngle, sweepAngle);
                   startAngle = startAngle + sweepAngle;

                   color++;

               }
              
           }
          
 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
            this.Hide();

        }



        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = Class1.n;
           /* Graphics gr = panel1.CreateGraphics();
            Rectangle r = new Rectangle(1, 1, 120, 120);

            Pen p1 = new Pen(Color.Black, 2);
            SolidBrush fill = new SolidBrush(Color.Orange);
            int sweepAngle = 90;
            int startAngle = 0;
            gr.DrawPie(p1, r, startAngle, sweepAngle);
            gr.FillPie(fill, r, startAngle, sweepAngle);
            gr.DrawPie(p1, r, startAngle, sweepAngle);

            label2.Text = (" 1\n____\n 4");*/
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 15)
            {
                count++;
                represent();
            }
            
           /* Graphics gr = panel1.CreateGraphics();

            gr.Clear(this.BackColor);
            int ind1 = randomNum.Next(0, 3);
            int ind2 = randomNum.Next(0, 6);
            int num1 = n[ind1];//specify index
            int dem1 = d[ind2];

            label2.Text = " " + (num1.ToString()) + "\n____\n" + " " + (dem1.ToString());


            Rectangle r = new Rectangle(1, 1, 120, 120);

            Pen p1 = new Pen(Color.Black, 2);
            SolidBrush fill = new SolidBrush(Color.Orange);

            int sweepAngle = (360 / dem1);

            int startAngle = 0;
            for (int i = 0; i < dem1; i++)
            {
                
              
                gr.DrawPie(p1, r, startAngle, sweepAngle);
                startAngle = startAngle + sweepAngle;
                   

            }
            startAngle = 0;
            int color = 0;
           while (color < num1)
            {

                gr.FillPie(fill, r, startAngle, sweepAngle);
                gr.DrawPie(p1, r, startAngle, sweepAngle);
                startAngle = startAngle + sweepAngle;

                color++;

            }*/

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            represent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (num)
            {
                case 1:
                    if (dem == 4)
                    {
                        t.Play();
                    }
                    else if (dem == 5) { t2.Play(); }
                    else if (dem == 6) { t3.Play();  }
                    else if (dem == 7) { t4.Play(); }
                    else if (dem == 8) { t5.Play(); }
                    break;
                case 2:
                    if (dem == 4)
                    {
                        t6.Play();
                    }
                    else if (dem == 5) { t7.Play(); }
                    else if (dem == 6) { t8.Play(); }
                    else if (dem == 7) { t9.Play(); }
                    else if (dem == 8) { t10.Play(); }
                    break;
                case 3:
                    if (dem == 4)
                    {
                        t11.Play();
                    }
                    else if (dem == 5) { t12.Play(); }
                    else if (dem == 6) { t13.Play(); }
                    else if (dem == 7) { t14.Play(); }
                    else if (dem == 8) { t5.Play(); }
                    break;
            }
        }
        }

   
}
