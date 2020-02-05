using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coonverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.SelectedIndex = 0;
            checkedListBox2.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, to;

            from = checkedListBox1.SelectedItem.ToString(); // выбранная валюта в 1 списке
            to = checkedListBox2.SelectedItem.ToString(); // выбранная валюта во 2 списке

            if (from == to)
            {
                MessageBox.Show("Это одна и та же валюта!", "Внимание!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Введите количество валюты!", "Внимание!");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + "" + from + " %D0%B2 " + to);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
