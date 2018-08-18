using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cronometro
{
    public partial class Form1 : Form
    {
        int ss = 0;
        int mm = 0;
        int hh = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ss++;
            lbss.Text = ss.ToString();
            if (ss == 59)
            {
                mm++;
                lbmm.Text = mm.ToString();
                ss = 0;
            }
            else if (mm == 59)
            {
                hh++;
                lbhh.Text = hh.ToString();
                mm = 0;
            }
            else if (hh == 23)
            {
                hh = 0;              
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ss = 0;
            mm = 0;
            hh = 0;
            button2_Click(sender, e);
            limpiar();
            //button1_Click(sender, e);
        }

        private void limpiar()
        {
            lbss.Text = "00";
            lbmm.Text = "00";
            lbhh.Text = "00";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
