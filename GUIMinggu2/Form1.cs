using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIMinggu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.label1.Text = "Halo " + this.textBox1.Text;
            }
            else
            {
                this.label1.Text = "Halo Semua";
            }
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Enabled = this.checkBox1.Checked;
        }
    }
}
