using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingPic
{
    public partial class Form1 : Form
    {
        public int x;
        public int y;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x > 500)
            {
                x = -410;
            }
            x = x+5;
            pictureBox1.Location = new Point(x, y);
        }
    }
}
