using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator_winform
{
    public partial class Calculator : Form
    {
        public int text1, text2;
        int result;
        public Calculator()
        {
            InitializeComponent();
          
        }

        private int Calculate(char a)
        {
            text1 = Int32.Parse(textBox1.Text);
            text2 = Int32.Parse(textBox2.Text);

            if (a == '+')
            {
                result = text1 + text2;
                return result;
            }
            else if (a == '-')
            {
                result = text1 - text2;
                return result;
            }
            else if (a == '*')
            {
                result = text1 * text2;
                return result;
            }
            else
            {
                try
                {
                    result = text1 / text2;
                }
                catch (Exception e)
                {
                    DivideAlertMessage form = new DivideAlertMessage();
                    form.ShowDialog();
                    EraseAll();
                }
                return result;
            }
        }

        private void EraseAll()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateBtn_click(object sender, EventArgs e)
        {
            textBox3.Text = result.ToString();
            
            
            
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            Calculate('-');
        }

        private void multipleBtn_Click(object sender, EventArgs e)
        {
            Calculate('*');
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            Calculate('/');
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            EraseAll();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            Calculate('+');
        }
    }
}
