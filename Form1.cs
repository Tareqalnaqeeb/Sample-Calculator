using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcaultor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonone_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void buttontwo_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";

        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";

        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";

        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";

        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";

        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";

        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";

        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ".";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }
        float Num;
        int Count;
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                Num = float.Parse(textBox2.Text);
                textBox1.Text = textBox2.Text + "+";
               
                textBox2.Clear();
                Count = 1;
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Num = float.Parse(textBox2.Text);
                textBox1.Text = textBox2.Text + "-";
                textBox2.Clear();
                Count = 2;
            }
        }

        private void buttonMutil_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Num = float.Parse(textBox2.Text);
                textBox1.Text = textBox2.Text + "*";
                textBox2.Clear();
                Count = 3;
            }
        }

        private void buttonDivid_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Num = float.Parse(textBox2.Text);
                textBox1.Text = textBox2.Text + "/";
                textBox2.Clear();
                Count = 4;
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Num = float.Parse(textBox2.Text);
                textBox1.Text = textBox2.Text + "%";
                textBox2.Clear();
                Count = 5;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            float Result;
            switch(Count)
            {
                case 1:
                    Result = Num + float.Parse(textBox2.Text);
                    textBox1.Text = textBox1.Text + textBox2.Text + "=" + Result;
                    textBox2.Text = Result.ToString();
                    break;

                case 2:
                    Result = Num - float.Parse(textBox2.Text);
                    textBox1.Text = textBox1.Text + textBox2.Text + "=" + Result;
                    textBox2.Text = Result.ToString();
                    break;

                case 3:
                    Result = Num * float.Parse(textBox2.Text);
                    textBox1.Text = textBox1.Text + textBox2.Text + "=" + Result;
                    textBox2.Text = Result.ToString();
                    break;
                case 4:
                    Result = Num / float.Parse(textBox2.Text);
                    textBox1.Text = textBox1.Text + textBox2.Text + "=" + Result;
                    textBox2.Text = Result.ToString();
                    break;
                case 5:
                    Result = Num % float.Parse(textBox2.Text);
                    textBox1.Text = textBox1.Text + textBox2.Text + "=" + Result;
                    textBox2.Text = Result.ToString();
                    break;

            }
        }

       
    }
}
