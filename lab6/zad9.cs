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
    public partial class zad9 : Form
    {
        public zad9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if ((char.IsLower(str[i])) || (str[i] == ' '))
                {
                    label1.Text += str[i];
                }
                if (str[i] == '0' || str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' ||
                    str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9')
                    label2.Text += str[i];
                if (str[i] == '.' || str[i] == '?' || str[i] == ',' || str[i] == '!' || str[i] == ':' ||
                    str[i] == ';' || str[i] == '(' || str[i] == ')' || str[i] == '"' || str[i] == '/')
                    label3.Text += str[i];
            }

        }
    }
}
