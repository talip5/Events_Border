using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_MouseMove
{
    public partial class Form1 : Form
    {
        string button1_text;
        int button2_Left;
        int button2_Top;
        Color button1_BackColor;
        public Form1()
        {
            InitializeComponent();

            this.MouseMove+=Form1_MouseMove;
            this.Load+=Form1_Load;

            button1.MouseMove+=Button1_MouseMove;
            button1.Click+=Button1_Click;

            button2.MouseMove+=Button2_MouseMove;
            button2.MouseUp+=Button2_MouseUp;

            button1_BackColor = button1.BackColor;
        }

        private void Button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Left = button2_Left;
            button2.Top = button2_Top;

            button1.Text = button1_text;
            button1.BackColor = button1_BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            this.FormBorderStyle = FormBorderStyle.None;

            button1_text = button1.Text;
            //button1_BackColor = button1.BackColor;

            button2_Left = button2.Left;
            button2_Top = button2.Top;
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && button2.Left < 725 && button2.Left > 1 && button2.Top > 1 && button2.Top < 420)
            {

                label1.Text = "X : " + button2.Left.ToString();
                label2.Text = "Y : " + button2.Top.ToString();

                //button1.Left +=e.X - (button1.Width/2);
                if (!(button2.Left > 500 && button2.Left <520 && button2.Top > 140 && button2.Top < 150)) {
                    button2.Left +=e.X;
                    button2.Top +=e.Y;
                    button1.Text = button1_text;
                }
                else
                {
                    button1.Text = "OK";
                    button1.BackColor = Color.Red;
                    
                }
            }

            if (button2.Left >= 725)
            {
                button2.Left =724;

            }

            if (button2.Left <= 1)
            {

                button2.Left = 2;
            }

            if (button2.Top <= 1)
            {

                button2.Top = 2;
            }

            if (button2.Top >= 420)
            {
                this.Text ="OK";
                button2.Top = 418;

            }
        }
    

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                
                label1.Text = e.X.ToString();

                //button1.Left +=e.X - (button1.Width/2);
                button1.Left +=e.X;
                button1.Top +=e.Y;
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Text = e.X.ToString();            
            }
        }
    }
}
