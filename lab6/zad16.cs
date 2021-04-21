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
    public partial class zad16 : Form
    {
        public zad16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            label1.Text = " ";
            string str1 = str.Replace(" ", "").ToLower();
            char[] toreverse = str1.ToCharArray();
            Array.Reverse(toreverse);
            string reversed = new string(toreverse);
            if (str1.Equals(reversed))
                label1.Text+="Полиндром!";
            else
                label1.Text += "Не полиндром!"; ;
        }
    }
}
