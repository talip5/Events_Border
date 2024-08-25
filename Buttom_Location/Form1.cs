using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttom_Location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.MouseUp+=Button1_MouseUp;
            this.MouseMove+=Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if(e.Button == MouseButtons.Right)
            {
                this.Text =e.X.ToString();
            }
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = color1;
        }

        Point konum;
        Color color1;
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            konum = (Point)e.Location;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //button1.Left +=e.X -(konum.X);
                //button1.Top +=e.Y - (konum.Y);
                button1.Left +=e.X - (konum.X);
                button1.Top +=e.Y - 15;
                //this.Text =button1.Left.ToString();
                //this.Text = konum.ToString();
           }

            if (e.Button == MouseButtons.Right)
            {
                button1.BackColor = Color.Orange;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           color1 = button1.BackColor;
        }
    }
}
