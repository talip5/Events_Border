using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Border
{
    public partial class Form1 : Form
    {
        public int x1;
        public int y1;
        public bool down = true;
        public Form1()
        {
            InitializeComponent();
            button1.MouseDown+=Button1_MouseDown;
            button1.MouseUp+=Button1_MouseUp;
            button1.MouseLeave+=Button1_MouseLeave;
            button1.MouseMove+=Button1_MouseMove;
            this.MouseMove+=Form1_MouseMove;
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = down.ToString();

            if (down)
            {
                x1 = e.X;
                y1 = e.Y;
                button1.Location = new Point(x1, y1);
                
            }
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Left :" ;
            label2.Text = " Right :" ;
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderColor = Color.Green;
            label2.Text = " Right :" + button1.Right.ToString();
            down = false;
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
           button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            //button1.FlatStyle = FlatStyle.Standard;
            button1.FlatAppearance.BorderColor = Color.Black;
            //button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.BorderSize = 0;
            label1.Text = "Left :" + button1.Left.ToString();
            //button1.Location = new Point(x1, y1);
            down = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = "Left :" + button1.Left.ToString();
            //label2.Text = " Right :" + button1.Right.ToString();
            //label3.Text = "Top :" + button1.Top.ToString();
            //label4.Text = " Bottom :" + button1.Bottom.ToString();
        }
    }
}
