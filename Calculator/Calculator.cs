using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private string divideOperator = '\u00F7'.ToString();
        private int count = 1; //insert or replace number on Screen.text
        private void Num0_Click(object sender, EventArgs e)
        {
            if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "0";
            else
            {
                Screen.Text = "0";
                count = 0;
            }
        }
        private void Num1_Click(object sender, EventArgs e)
        {
            if(count == 1)
            {
                Screen.Text = "1";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "1";
            
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if(count == 1)
            {
                Screen.Text = "2";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "2";
            
            
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "3";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "4";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "5";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "6";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "7";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "8";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "9";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "9";
        }
        private bool checkAddition = false;
        private bool checkSubtraction = false;
        private bool checkMultiplication = false;
        private bool checkDivision = false;
        private void Result_Click(object sender, EventArgs e)
        {
            if (Expression.Text.Contains("="))
            {
                double number1 = Convert.ToDouble(Screen.Text);
                double number2 = Convert.ToDouble(Expression.Text.Split(' ')[2]);
                string Operator = Expression.Text.Split(' ')[1];
                if (Operator.Equals("+"))
                {
                    Screen.Text = (number1 + number2).ToString();
                    Expression.Text = number1.ToString() + " + " + number2.ToString() + " =";
                }
                else if (Operator.Equals("-"))
                {
                    Screen.Text = (number1 - number2).ToString();
                    Expression.Text = number1.ToString() + " - " + number2.ToString() + " =";
                }
                else if (Operator.Equals("*"))
                {
                    Screen.Text = (number1 * number2).ToString();
                    Expression.Text = number1.ToString() + " * " + number2.ToString() + " =";
                }
                else if (Operator.Equals(divideOperator))
                {
                    Screen.Text = (number1 / number2).ToString();
                    Expression.Text = number1.ToString() + $" {divideOperator} " + number2.ToString() + " =";
                }
            }
            else if (checkAddition)
            {
                double number1 = Convert.ToDouble(Screen.Text);
                double number2 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                Screen.Text = (number1 + number2).ToString();
                Expression.Text += (" " + number1.ToString() + " =");
                checkAddition = false;
            }
            else if(checkSubtraction)
            {
                double number1 = Convert.ToDouble(Screen.Text);
                double number2 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                Screen.Text = (number2 - number1).ToString();
                Expression.Text += (" " + number1.ToString() + " =");
                checkSubtraction = false;
            }
            else if(checkMultiplication)
            {
                double number1 = Convert.ToDouble(Screen.Text);
                double number2 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                Screen.Text = (number1 * number2).ToString();
                Expression.Text += (" " + number1.ToString() + " =");
                checkMultiplication = false;
            } 
            else if(checkDivision)
            {
                double number1 = Convert.ToDouble(Screen.Text);
                double number2 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                Screen.Text = (number2 / number1).ToString();
                Expression.Text += (" " + number1.ToString() + " =");
                checkMultiplication = false;
            }
            else if(Screen.Text.Equals("Invalid Input"))
            {
                Screen.Text = "0";
            }
            else
            {
                Expression.Text = Screen.Text + " =";
            }
            count = 1;
        }
        
        private void Add_Click(object sender, EventArgs e)
        {
            double number1 = 0;
            double number2 = 0;
            checkAddition = true;
            if (Expression.Text.Contains("+") && !Expression.Text.Contains("="))
            {
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number1 + number2).ToString() + " +";
            }
            else if (Expression.Text.Contains("-") && !Expression.Text.Contains("="))
            {
                checkSubtraction = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number2 - number1).ToString() + " +";
            }
            else if (Expression.Text.Contains("*") && !Expression.Text.Contains("="))
            {
                checkMultiplication = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number1 * number2).ToString() + " +";
            }
            else if (Expression.Text.Contains(divideOperator) && !Expression.Text.Contains("="))
            {
                checkDivision = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number2 / number1).ToString() + " +";
            }
            else
            {
                Expression.Text = Screen.Text + " +";
            }
            count = 1;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double number1 = 0;
            double number2 = 0;
            checkSubtraction= true;
            if (Expression.Text.Contains("+") && !Expression.Text.Contains("="))
            {
                checkAddition = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number1 + number2).ToString() + " -";;
            }
            else if (Expression.Text.Contains("-") && !Expression.Text.Contains("="))
            {
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number2 - number1).ToString() + " -";
            }
            else if (Expression.Text.Contains("*") && !Expression.Text.Contains("="))
            {
                checkMultiplication = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number1 * number2).ToString() + " -";
            }
            else if (Expression.Text.Contains(divideOperator) && !Expression.Text.Contains("="))
            {
                checkDivision = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number2 / number1).ToString() + " -"; 
            }
            else
            {
                Expression.Text = Screen.Text + " -";
            }
            count = 1;
        }

        private void Product_Click(object sender, EventArgs e)
        {
            double number1 = 0;
            double number2 = 0;
            checkMultiplication = true;
            if (Expression.Text.Contains("+") && !Expression.Text.Contains("="))
            {
                checkAddition = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number1 + number2).ToString() + " *";
            }
            else if (Expression.Text.Contains("-") && !Expression.Text.Contains("="))
            {
                checkSubtraction = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number2 - number1).ToString() + " *";
            }
            else if (Expression.Text.Contains("*") && !Expression.Text.Contains("="))
            {
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number1 * number2).ToString() + " *";
            }
            else if (Expression.Text.Contains(divideOperator) && !Expression.Text.Contains("="))
            {
                checkDivision = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number2 / number1).ToString() + " *";
            }
            else
            {
                Expression.Text = Screen.Text + " *";
            }
            count = 1;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            double number1 = 0;
            double number2 = 0;
            checkDivision = true;
            if (Expression.Text.Contains("+") && !Expression.Text.Contains("="))
            {
                checkAddition = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number1 + number2).ToString() + " /";
            }
            else if (Expression.Text.Contains("-") && !Expression.Text.Contains("="))
            {
                checkSubtraction = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number2 - number1).ToString() + " /";
            }
            else if (Expression.Text.Contains("*") && !Expression.Text.Contains("="))
            {
                checkMultiplication = false;
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number1 * number2).ToString() + " /";
            }
            else if (Expression.Text.Contains(divideOperator) && !Expression.Text.Contains("="))
            {
                number1 = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                number2 = Convert.ToDouble(Screen.Text);
                Expression.Text = (number2 / number1).ToString() + " " + divideOperator;
            }
            else
            {
                Expression.Text = Screen.Text + " " +divideOperator;
            }
            count = 1;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!Screen.Text.Contains("."))
            {
                if (count == 1)
                {
                    Screen.Text = "0.";
                    count = 0;
                }
                else
                {
                    Screen.Text += ".";
                }
            }
            else
            {
                MessageBox.Show("Number doesn't exist");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(Screen.Text != "0" && Screen.Text.Length > 1)
            {
                Screen.Text = Screen.Text.Substring(0,Screen.Text.Length - 1);
            }
            else
            {
                Screen.Text = "0";
                count = 1;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            Expression.Text = "";
            count = 1;
        }

        private void ClearScreen_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            count = 1;
        }

        private void Inverse_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(Screen.Text);
            if (Expression.Text.Contains("1/("))
            {
                Expression.Text = ("1/(" + Expression.Text + ")");
            }
            else
            {
                Expression.Text = "1/(" + number1 + ")";
            }
            if(number1 != 0) Screen.Text = (1.0 / number1).ToString();
            else
            {
                Expression.Text = "";
                Screen.Text = "Invalid Input";
            }
            count = 1;
        }

        private void Duplicate_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(Screen.Text);
            if (Expression.Text.Contains("sqr"))
            {
                Expression.Text = ("sqr(" + Expression.Text + ")");
            }
            else
            {
                Expression.Text = "sqr(" + number1 + ")";
            }
            Screen.Text = (number1 * number1).ToString();
            count = 1;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(Screen.Text);
            if(Expression.Text.Contains("sqrt"))
            {
                Expression.Text += ("sqrt(" + Expression.Text + ")");
            }
            else
            {
                Expression.Text = "sqrt(" + number1 + ")";
            }
            if (number1 >= 0) Screen.Text = (Math.Sqrt(number1)).ToString();
            else
            {
                Expression.Text = "";
                Screen.Text = "Invalid Input";
            }
            count = 1;
        }

        private void DivideHundred_Click(object sender, EventArgs e)
        {

        }
    }
}
