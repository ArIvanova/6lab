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
    public partial class zad6 : Form
    {
        public zad6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int i = 0;
            label1.Text = " ";
            label2.Text = " ";
            while (i < len)
            {
                if (i%2==0)
                    label1.Text += str[i];
                else if (i%2==1)
                    label2.Text += str[i];
                i++;
               
            }
        }
    }
}
