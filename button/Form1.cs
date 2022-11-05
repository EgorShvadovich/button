using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 400);
        }
       Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(random.Next(0, 700), random.Next(0, 300));
        }
    }
}
