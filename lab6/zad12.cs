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
    public partial class zad12 : Form
    {
        public zad12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            String s, s0;
            s0 = "";
            String[] ss = listBox1.Text.Split(' ');
            for (int i = 0; i < ss.Count(); i++)
            {
                s = ss[i].Substring(1, ss[i].Length - 1);
                s0 += (s + " ");
            }
            label1.Text = s0;
        }
    }
}
