using System;
using System.Windows.Forms;  

namespace computer_frame
{
    public partial class Form1 : Form
    {
        Boolean flag;  //判断文本框内是否有数字
        double a = 0;
        double b = 0;
        string c;

        public Form1()
        {
            InitializeComponent();

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1是下面输入和显示结果的文本框
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2是上面显示的文本框
        }
        
        private void btn_equal_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+": a = b + double.Parse(textBox1.Text); textBox2.AppendText(double.Parse(textBox1.Text).ToString()); break;
                case "-": a = b - double.Parse(textBox1.Text); textBox2.AppendText(double.Parse(textBox1.Text).ToString()); break;
                case "×": a = b * double.Parse(textBox1.Text); textBox2.AppendText(double.Parse(textBox1.Text).ToString()); break;
                case "÷":a = b / double.Parse(textBox1.Text); textBox2.AppendText(double.Parse(textBox1.Text).ToString());break;
                case "%": a = b % double.Parse(textBox1.Text); textBox2.AppendText(double.Parse(textBox1.Text).ToString()); break;
                case "^2": a = b * b; break;
                case "sqrt": a = Math.Sqrt(b); break;
                case "log": a = Math.Log(b, 2); break;
                case "倒数": a = 1/ b; break;
            }
            textBox1.Text = a + "";
            flag = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "+";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText(b.ToString());
            textBox2.AppendText("+");
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "-";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText(b.ToString());
            textBox2.AppendText("-");
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "×";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText(b.ToString());
            textBox2.AppendText("×");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "÷";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText(b.ToString());
            textBox2.AppendText("÷");
        }

        private void btn_jiajian_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "%";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText(b.ToString());
            textBox2.AppendText("%");
        }

        private void btn_rad_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "sqrt";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText("√" + b.ToString());
        }

        private void btn_per_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "log";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText("log2" + "(" + b.ToString() + ")");
        }
        
        private void btn_1x_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "倒数";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText("1/" + b.ToString());
        }

        private void btn_x2_Click(object sender, EventArgs e)
        {
            flag = true;
            b = double.Parse(textBox1.Text);
            c = "^2";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.AppendText(b.ToString() + "^2");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "4";

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "9";
        }

        

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                textBox1.Text = "";
                flag = false;
            }
            textBox1.Text += "0";
            if (c == "÷")
            {
                textBox1.Clear();
                MessageBox.Show("除数不能为零", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
            }
            else if (textBox1.Text.IndexOf(".") >= 0)
            {
                MessageBox.Show("已经添加小数点l！", "提示");
            }
            else
            {
                textBox1.Text += ".";
            }
        }

        private void btn_ca_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            a = 0;
            b = 0;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
