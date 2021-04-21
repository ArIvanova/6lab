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
    public partial class zad20 : Form
    {
        public zad20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            label1.Text = " ";
            string[] split = str.Split(' ');

            string NEWstr = split[split.Length - 1];
            for (int i = 1; i < split.Length - 1; i++)
                NEWstr += " " + split[i];

            NEWstr += " " + split[0];
            label1.Text += NEWstr;
        }
    }
}
