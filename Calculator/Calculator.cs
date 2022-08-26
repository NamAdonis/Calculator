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
        private bool checkValidInput = false;
        private void Num0_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "0";
                count = 0;
            }
            else if(Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "0";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
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
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if(count == 1)
            {
                Screen.Text = "2";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "2";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }

        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "3";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "3";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "4";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "4";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "5";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "5";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "6";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "6";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "7";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "7";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "8";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "8";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                Screen.Text = "9";
                count = 0;
            }
            else if (Screen.Text != "0" && !Expression.Text.Contains("-") && !Expression.Text.Contains("+") && !Expression.Text.Contains("x") || count != 1) Screen.Text += "9";
            if (checkValidInput)
            {
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
        }
        private bool checkAddition = false;
        private bool checkSubtraction = false;
        private bool checkMultiplication = false;
        private bool checkDivision = false;
        private void Result_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Equals("Invalid Input"))
            {
                Expression.Text = "";
                Screen.Text = "0";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
            else if (Expression.Text.Contains("="))
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
                if (number1 != 0) Screen.Text = (number2 / number1).ToString();
                else
                {
                    Screen.Text = "Invalid Input";
                    Inverse.Enabled = false;
                    Duplicate.Enabled = false;
                    Square.Enabled = false;
                    Divide.Enabled = false;
                    Product.Enabled = false;
                    Minus.Enabled = false;
                    Add.Enabled = false;
                    Dot.Enabled = false;
                    negaPosi.Enabled = false;
                    DivideHundred.Enabled = false;
                    checkValidInput = true;
                }
                Expression.Text += (" " + number1.ToString() + " =");
                checkMultiplication = false;
            }
            else
            {
                Expression.Text = Screen.Text + " =";
            }
            count = 1;
            hundredReplay = 0;
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
                if(number1 != 0) Expression.Text = (number2 / number1).ToString() + " +";
                else
                {
                    Screen.Text = "Invalid Input";
                    Inverse.Enabled = false;
                    Duplicate.Enabled = false;
                    Square.Enabled = false;
                    Divide.Enabled = false;
                    Product.Enabled = false;
                    Minus.Enabled = false;
                    Add.Enabled = false;
                    Dot.Enabled = false;
                    negaPosi.Enabled = false;
                    DivideHundred.Enabled = false;
                    checkValidInput = true;
                }
            }
            else
            {
                Expression.Text = Screen.Text + " +";
            }
            hundredReplay = 0;
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
                if(number1 != 0) Expression.Text = (number2 / number1).ToString() + " -";
                else
                {
                    Screen.Text = "Invalid Input";
                    Inverse.Enabled = false;
                    Duplicate.Enabled = false;
                    Square.Enabled = false;
                    Divide.Enabled = false;
                    Product.Enabled = false;
                    Minus.Enabled = false;
                    Add.Enabled = false;
                    Dot.Enabled = false;
                    negaPosi.Enabled = false;
                    DivideHundred.Enabled = false;
                    checkValidInput = true;
                }
            }
            else
            {
                Expression.Text = Screen.Text + " -";
            }
            hundredReplay = 0;
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
                if(number1 != 0) Expression.Text = (number2 / number1).ToString() + " *";
                else
                {
                    Screen.Text = "Invalid Input";
                    Inverse.Enabled = false;
                    Duplicate.Enabled = false;
                    Square.Enabled = false;
                    Divide.Enabled = false;
                    Product.Enabled = false;
                    Minus.Enabled = false;
                    Add.Enabled = false;
                    Dot.Enabled = false;
                    negaPosi.Enabled = false;
                    DivideHundred.Enabled = false;
                    checkValidInput = true;
                }
            }
            else
            {
                Expression.Text = Screen.Text + " *";
            }
            hundredReplay = 0;
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
                if(number1 != 0) Expression.Text = (number2 / number1).ToString() + " " + divideOperator;
                else
                {
                    Screen.Text = "Invalid Input";
                    Inverse.Enabled = false;
                    Duplicate.Enabled = false;
                    Square.Enabled = false;
                    Divide.Enabled = false;
                    Product.Enabled = false;
                    Minus.Enabled = false;
                    Add.Enabled = false;
                    Dot.Enabled = false;
                    negaPosi.Enabled = false;
                    DivideHundred.Enabled = false;
                    checkValidInput = true;
                }
            }
            else
            {
                Expression.Text = Screen.Text + " " +divideOperator;
            }
            hundredReplay = 0;
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
            if (checkValidInput)
            {
                Screen.Text = "0";
                Expression.Text = "";
                Inverse.Enabled = true;
                Duplicate.Enabled = true;
                Square.Enabled = true;
                Divide.Enabled = true;
                Product.Enabled = true;
                Minus.Enabled = true;
                Add.Enabled = true;
                Dot.Enabled = true;
                negaPosi.Enabled = true;
                DivideHundred.Enabled = true;
                checkValidInput = false;
            }
            else if (Screen.Text != "0" && Screen.Text.Length > 1)
            {
                Screen.Text = Screen.Text.Substring(0,Screen.Text.Length - 1);
            }
            else
            {
                Screen.Text = "0";
                count = 1;
            }
            hundredReplay = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            Expression.Text = "";
            hundredReplay = 0;
            count = 1;
        }

        private void ClearScreen_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            hundredReplay = 0;
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
                Inverse.Enabled = false;
                Duplicate.Enabled = false;
                Square.Enabled = false;
                Divide.Enabled = false;
                Product.Enabled = false;
                Minus.Enabled = false;
                Add.Enabled = false;
                Dot.Enabled = false;
                negaPosi.Enabled = false;
                DivideHundred.Enabled = false;
            }
            count = 1;
            hundredReplay = 0;
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
            hundredReplay = 0;
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
                Inverse.Enabled = false;
                Duplicate.Enabled = false;
                Square.Enabled = false;
                Divide.Enabled = false;
                Product.Enabled = false;
                Minus.Enabled = false;
                Add.Enabled = false;
                Dot.Enabled = false;
                negaPosi.Enabled = false;
                DivideHundred.Enabled = false;
            }
            count = 1;
            hundredReplay = 0;
        }
        private double hundredReplay;
        private void DivideHundred_Click(object sender, EventArgs e)
        {
            if(Expression.Text.Contains("="))
            {
                Screen.Text =Math.Abs((Convert.ToDouble(Screen.Text) / 100) * (Convert.ToDouble(Screen.Text))).ToString();
                Expression.Text = Screen.Text;
                hundredReplay = Math.Abs((Convert.ToDouble(Screen.Text) / 100));
            }
            else if(Expression.Text.Contains("+") || Expression.Text.Contains("-") || Expression.Text.Contains("*") || Expression.Text.Contains(divideOperator))
            {
                double number = Convert.ToDouble(Expression.Text.Split(' ')[0]);
                string Operator = Expression.Text.Split(' ')[1];
                if (count == 1)
                {
                    if (Expression.Text.Split(' ').Length < 3)
                    {
                        Screen.Text = (number * number/ 100).ToString();
                        Expression.Text = number.ToString() + " " + Operator +" " + (number * number / 100).ToString();
                    }
                    else
                    {
                        Screen.Text = (Convert.ToDouble(Expression.Text.Split(' ')[2]) * number / 100).ToString();
                        Expression.Text = number + " " + Operator + " " + Screen.Text;
                    }
                }
                else
                {
                    Screen.Text = (Convert.ToDouble(Screen.Text) * number / 100).ToString();
                    Expression.Text = number + " " + Operator + " " + Screen.Text;
                    count = 1;
                }
            }
            else if(Screen.Text != "0" && Screen.Text.Equals(Expression.Text))
            {
                Screen.Text = (Convert.ToDouble(Screen.Text) * hundredReplay).ToString();
                Expression.Text = Screen.Text;
            }
            else
            {
                Screen.Text = "0";
                Expression.Text = "0";
            }
        }

        private void negaPosi_Click(object sender, EventArgs e)
        {
            if(Screen.Text.Contains("-"))
            {
                Screen.Text = Screen.Text.Remove(0,1);
            }
            else
            {
                Screen.Text = "-" + Screen.Text;
            }
        }
    }
}
