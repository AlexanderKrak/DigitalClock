using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private Color GetRandomColour()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToString("HH:mm:ss");
            dateLbl.Text = DateTime.Now.ToString("yyyy MM dd");

            if((DateTime.Now.Minute) % 2 == 0)
            {
                timeLbl.ForeColor = GetRandomColour();
            }
            timeLbl.ForeColor = GetRandomColour();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
