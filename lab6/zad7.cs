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
    public partial class zad7 : Form
    {
        public zad7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int i = 0;
            int c = 0;
            label1.Text = " ";
            while (i < len)
            {
                if (str[i] != ' ') 
                    i++;
                else
                {
                    if (str[i - 1] % 2 == 0)
                    c++;
                    i++;
                }
            }
            label1.Text = "Количество четных цифр: " + c.ToString();
        }
    }
}
