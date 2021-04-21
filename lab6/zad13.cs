using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class zad13 : Form
    {
        public zad13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] s = listBox1.Text.ToCharArray();
            int i = Convert.ToInt32(textBox1.Text) - 1;
            int j = Convert.ToInt32(textBox2.Text) - 1;

            char tmp = s[i];
            s[i] = s[j];
            s[j] = tmp;

            label1.Text = new string(s);
        }
    }
}
