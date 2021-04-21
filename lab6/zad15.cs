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
    public partial class zad15 : Form
    {
        public zad15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            label1.Text = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]=='А')
                {
                    label1.Text += "*";
                }
                else
                {
                    label1.Text += str[i];
                }
            }
        }
    }
}
