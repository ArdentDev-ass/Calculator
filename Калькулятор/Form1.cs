using System;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || operationPressed)
                textBox_Result.Clear();

            operationPressed = false;
            Button b = (Button)sender;
            textBox_Result.Text += b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(textBox_Result.Text);
            operationPressed = true;
        }

        private void button16_Click(object sender, EventArgs e) 
        {
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (value + double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (value - double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (value * double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(textBox_Result.Text) != 0)
                        textBox_Result.Text = (value / double.Parse(textBox_Result.Text)).ToString();
                    else
                        textBox_Result.Text = "еррар";
                    break;
            }
            operationPressed = false;
        }

        private void button5_Click(object sender, EventArgs e) 
        {
            textBox_Result.Text = "0";
            value = 0;
        }
    }
}
