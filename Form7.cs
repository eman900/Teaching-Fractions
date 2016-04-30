using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            drawwithsum();
        }

        public  int[] n = { 1, 2, 3 };
        public  int[] d = { 4, 5, 6, 7, 8, 9 };
        public  Random randomNum = new Random();
        public int gcd(int n, int d) {
            int r = d % n;
            while (r != 0)
            {
                d = n;
                n = r;
                r = d % n;
            }
            return n; 
        }
        public void drawwithsum()
        {
            Graphics gr = panel1.CreateGraphics();

            gr.Clear(this.BackColor);
            int ind1 = randomNum.Next(0, 3);
            int ind2 = randomNum.Next(0, 6);
            int num1 = n[ind1];//specify index
            int dem1 = d[ind2];

            label4.Text = num1.ToString(); 
            label8.Text = dem1.ToString();

            Rectangle r = new Rectangle(1, 1, 70, 70);

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

            Graphics g = panel2.CreateGraphics();

            g.Clear(this.BackColor);
            int ind3 = randomNum.Next(0, 3);
            int ind4 = randomNum.Next(0, 6);
            int num2 = n[ind3];//specify index
            int dem2 = d[ind4];

            label2.Text = num2.ToString();
            label9.Text = dem2.ToString();

            Rectangle rr = new Rectangle(1, 1, 70, 70);

            Pen p2 = new Pen(Color.Black, 2);
            SolidBrush fill2 = new SolidBrush(Color.Orange);

            int sweepAngle2 = (360 / dem2);

            int startAngle2 = 0;
            for (int k = 0; k < dem2; k++)
            {


                g.DrawPie(p2, rr, startAngle2, sweepAngle2);
                startAngle2 = startAngle2 + sweepAngle2;


            }
            startAngle2 = 0;
            int col = 0;
            while (col < num2)
            {

                g.FillPie(fill2, rr, startAngle2, sweepAngle2);
                g.DrawPie(p2, rr, startAngle2, sweepAngle2);
                startAngle2 = startAngle2 + sweepAngle2;

                col++;
            }

            int newdem = dem1 * dem2;
            int newnem = (num1 * dem2) + (num2 * dem1);
            int gc = gcd(newnem, newdem);
            int nn = newnem / gc;
            int dd = newdem / gc;
            label5.Text = " " + (nn) + "\n____\n" + " " + (dd);

            Graphics gra = panel3.CreateGraphics();

            gra.Clear(this.BackColor);





            Rectangle rrr = new Rectangle(1, 1, 70, 70);

            Pen p3 = new Pen(Color.Black, 2);
            SolidBrush fill3 = new SolidBrush(Color.Orange);

            int sweepAngle3 = (360 / dd);

            int startAngle3 = 0;
            for (int k = 0; k < dd; k++)
            {


                gra.DrawPie(p3, rrr, startAngle3, sweepAngle3);
                startAngle3 = startAngle3 + sweepAngle3;


            }
            startAngle3 = 0;
            int co = 0;
            while (co < nn)
            {

                gra.FillPie(fill3, rrr, startAngle3, sweepAngle3);
                gra.DrawPie(p3, rrr, startAngle3, sweepAngle3);
                startAngle3 = startAngle3 + sweepAngle3;

                co++;
            }

        }
       

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawwithsum();
        /*   Graphics gr = panel1.CreateGraphics();
            gr.Clear(this.BackColor);
            int ind1 = randomNum.Next(0, 3);
            int ind2 = randomNum.Next(0, 6);
            int num1 = n[ind1];//specify index
            int dem1 = d[ind2];
            label4.Text =  num1.ToString(); 
            label8.Text =  dem1.ToString();
            Rectangle r = new Rectangle(1, 1, 80, 80);

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

            Graphics g = panel2.CreateGraphics();

            g.Clear(this.BackColor);
            int ind3 = randomNum.Next(0, 3);
            int ind4 = randomNum.Next(0, 6);
            int num2 = n[ind3];//specify index
            int dem2 = d[ind4];

            label2.Text = num2.ToString(); 
            label9.Text = dem2.ToString();

            Rectangle rr = new Rectangle(1, 1, 80, 80);

            Pen p2 = new Pen(Color.Black, 2);
            SolidBrush fill2 = new SolidBrush(Color.Orange);

            int sweepAngle2 = (360 / dem2);

            int startAngle2 = 0;
            for (int k = 0; k < dem2; k++)
            {


                g.DrawPie(p2, rr, startAngle2, sweepAngle2);
                startAngle2 = startAngle2 + sweepAngle2;


            }
            startAngle2 = 0;
            int col = 0;
            while (col < num2)
            {

                g.FillPie(fill2, rr, startAngle2, sweepAngle2);
                g.DrawPie(p2, rr, startAngle2, sweepAngle2);
                startAngle2 = startAngle2 + sweepAngle2;

                col++;
            } 
            int newdem = dem1 * dem2;
            int newnem = (num1 * dem2) + (num2 * dem1);
            int gc = gcd(newnem, newdem);
            int nn = newnem / gc;
            int dd = newdem / gc; 
            label5.Text = " " + (nn) + "\n____\n" + " " + (dd) ;

            Graphics gra = panel3.CreateGraphics();

            gra.Clear(this.BackColor);
            
            

            

            Rectangle rrr = new Rectangle(1, 1, 70, 70);

            Pen p3 = new Pen(Color.Black, 2);
            SolidBrush fill3 = new SolidBrush(Color.Orange);

            int sweepAngle3 = (360 / dd);

            int startAngle3 = 0;
            for (int k = 0; k < dd; k++)
            {


                gra.DrawPie(p3, rrr, startAngle3, sweepAngle3);
                startAngle3 = startAngle3 + sweepAngle3;


            }
            startAngle3 = 0;
            int co = 0;
            while (co < nn)
            {

                gra.FillPie(fill3, rrr, startAngle3, sweepAngle3);
                gra.DrawPie(p3, rrr, startAngle3, sweepAngle3);
                startAngle3 = startAngle3 + sweepAngle3;

                co++;
            }*/

            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Text = Class1.n;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawwithsum();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            drawwithsum();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            drawwithsum();
        }
    }
}
