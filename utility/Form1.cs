using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility
{
  public partial class frmDashboard : Form
  {
    public frmDashboard()
    {
      InitializeComponent();
    }

    private void button10_Click(object sender, EventArgs e)
    {
      textBox1.Text += "0";
    }
    private void button3_Click(object sender, EventArgs e)
    {
      textBox1.Text += "1";
    }

    private void button8_Click(object sender, EventArgs e)
    {
      textBox1.Text += "2";
    }

    private void button4_Click(object sender, EventArgs e)
    {
      textBox1.Text += "3";
    }

    private void button5_Click(object sender, EventArgs e)
    {
      textBox1.Text += "4";
    }

    private void button6_Click(object sender, EventArgs e)
    {
      textBox1.Text += "5";
    }

    private void button7_Click(object sender, EventArgs e)
    {
      textBox1.Text += "6";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox1.Text += "7";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox1.Text += "8";
    }

    private void btn1_Click(object sender, EventArgs e)
    {
      textBox1.Text += "9";
    }

    private void button9_Click(object sender, EventArgs e)
    {
      textBox1.Text += "+";
    }

    private void button14_Click(object sender, EventArgs e)
    {
      // 25+41+3a
      //textBox1.Text = 25+41;
      //input value = textBox1.Text;
      //split the input value based on +,-,*,/;
      //first value = 25;
      //second value = 41;
      //operator = +;
      //cast first value and second value to int
      //if operator is + then add first value and second value
      //result = first value + second value;
      //textBox1.Text = result;

      string input = textBox1.Text;
      char[] operators = new char[] { '+', '-', '*', '/' };
      foreach (char op in operators)
      {
        if (input.Contains(op))
        {
          string[] values = input.Split(op);
          //values[0] = "25"
          //values[1] = "41"
          //array values = [25,41]
          // array fruits = new array(3);
          // fruits = [apple,banana,grape]
          // fruits[0] = apple
          // fruits[1] = banana
          // fruits[2] = grape

          if (values.Length == 2)
          {
            string fistValueStr = values[0];
            string secondValueStr = values[1];

            int fistValue = int.Parse(fistValueStr);
            int secondValue = int.Parse(secondValueStr);

            switch (op)
            {
              case '+':
                int result = fistValue + secondValue;
                textBox1.Text = result.ToString();
                break;
              case '-':
                int resultSub = fistValue - secondValue;
                textBox1.Text = resultSub.ToString();
                break;
              case '*':
                int resultMul = fistValue * secondValue;
                textBox1.Text = resultMul.ToString();
                break;
              case '/':
                if (secondValue != 0)
                {
                  int resultDiv = fistValue / secondValue;
                  textBox1.Text = resultDiv.ToString();
                }
                else
                {
                  textBox1.Text = "Error: Division by zero";
                }
                break;
            }

            if (op == '+')
            {
              int result= fistValue + secondValue;
              textBox1.Text = result.ToString();
            }
          }
        }
      }
    }
  }
}
