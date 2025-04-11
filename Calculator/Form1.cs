using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation = "";
        double resultValue = 0;
        bool isOperationPerformed = false;

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            resultValue = double.Parse(textBox_Result.Text);
            isOperationPerformed = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Nếu đang nhập phép tính mới hoặc đang là 0 thì xóa trước khi nhập tiếp
            if ((textBox_Result.Text == "0") || isOperationPerformed)
                textBox_Result.Clear();

            isOperationPerformed = false;

            // Nếu là dấu chấm thì kiểm tra xem textbox đã có chấm chưa
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }
            else
            {
                textBox_Result.Text += button.Text;
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "CE")
            {
                textBox_Result.Text = "0";
            }
            else if (button.Text == "C")
            {
                textBox_Result.Text = "0";
                resultValue = 0;
                operation = "";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (resultValue + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / double.Parse(textBox_Result.Text)).ToString();
                    break;
            }
        }
    }
}
