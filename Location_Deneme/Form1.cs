using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location_Deneme
{
    public partial class Form1 : Form

    {
        public Point point1;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Orange;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            point1 = new Point();
            point1 = button1.Location;
            label1.Text = point1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form();
           
            //form1 = new Form1();
            form1.Text = "xxx";
            form1.Show();
            button2.Location =new Point((point1.X + 80),(point1.Y));
        }
    }
}
