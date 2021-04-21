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
    public partial class zad19 : Form
    {
        public zad19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            label1.Text = " ";
            String[] words = str.Split(' ');
            string firstWord = words[0];
            string twoWord = words[1];
            words[0] = twoWord;
            words[1] = firstWord;
            string swapped = string.Join(" ", words);
            label1.Text += swapped; 
        }
    }
}
