using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("قبل البدء أدخل اسمك");
            }
            else
            {
                SoundPlayer t = new SoundPlayer("sounds/welcome.wav");
                t.Play();
                Form13 F = new Form13();
                this.Hide();
                F.Show();
            }
            
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
