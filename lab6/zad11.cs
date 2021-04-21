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
    public partial class zad11 : Form
    {
        public zad11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string str2 = string.Empty;
            label1.Text = " ";
            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Count(); i++)
            {
                str2 = arr[i].Substring(0, 1).ToUpper();
                arr[i] = str2 + arr[i].Substring(1, arr[i].Length - 1);
                label1.Text += arr[i];
            }
        }
    }
}
