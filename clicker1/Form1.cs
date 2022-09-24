using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker1
{
    public partial class Form1 : Form
    {
        int licznik = 0;
        int seconds = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            licznik += 1;
            textBox1.Text = licznik.ToString();
            
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds += 1; 

            if(seconds == 10)
            {
                button1.Enabled = false;                
                timer1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            licznik = 0;
            textBox1.Text = licznik.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
