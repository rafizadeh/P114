using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28022020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string InsertCommaBetween(string text)
            {

                return string.Join(",", text.ToCharArray());
            }


            string str = textBox3.Text;

            MessageBox.Show(InsertCommaBetween(str));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox3.Text;
            int digit = 0;
            int letter = 0;
            int character = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    digit++;
                }
                else if(Char.IsLetter(str[i]))
                {
                    letter++;
                }
                else
                {
                    character++;
                }
            }
            MessageBox.Show("Letter: " + letter + " Digit: " + digit + " Character:" + character);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBox3.Text;

            MessageBox.Show(str.Replace(" ",""));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] inputString = textBox3.Text.Split(' ');
            string res = "";

            foreach (var item in inputString)
            {
                for (int j = item.Length - 1; j >= 0; j--)
                {
                    res += item[j];
                }
                if (res.Length < textBox3.Text.Length)
                {
                    res += " ";
                }
            }
            
            MessageBox.Show(res.ToUpper());
        }
    }
}
