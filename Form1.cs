using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double _sum = 0;
        private string _lastOperation = string.Empty;
        private bool _isAbleToWriteNumbers = true;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void OneButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("3");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("7");
        }

        private void EightButtno_Click(object sender, EventArgs e)
        {
            AddNumberToSum("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("9");
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            AddNumberToSum("0");
        }

        private void SlashButton_Click(object sender, EventArgs e)
        {
            this._isAbleToWriteNumbers = true;
            MakeLastOperation(double.Parse(SumTextBox.Text));
            SumTextBox.Text = "0";

            if (this._sum == 0)
            {
                this._lastOperation = string.Empty;
            }

            this._lastOperation = "/";
        }

        private void MultipleButton_Click(object sender, EventArgs e)
        {
            this._isAbleToWriteNumbers = true;
            MakeLastOperation(double.Parse(SumTextBox.Text));
            SumTextBox.Text = "0";
            this._lastOperation = "*";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            this._isAbleToWriteNumbers = true;
            MakeLastOperation(double.Parse(SumTextBox.Text));
            SumTextBox.Text = "0";
            this._lastOperation = "-";
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            this._isAbleToWriteNumbers = true;
            MakeLastOperation(double.Parse(SumTextBox.Text));
            SumTextBox.Text = "0";
            this._lastOperation = "+";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            MakeLastOperation(double.Parse(SumTextBox.Text));
            SumTextBox.Text = this._sum.ToString();
            this._lastOperation = string.Empty;
            this._isAbleToWriteNumbers = false;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this._sum = 0;
            this._lastOperation = string.Empty;
            SumTextBox.Text = "0";
        }

        private void AddNumberToSum(string number)
        {
            if (!this._isAbleToWriteNumbers)
            {
                CButton_Click(null, null);
                this._isAbleToWriteNumbers = true;
            }

            if (!Regex.IsMatch(SumTextBox.Text, "^.{0,20}$"))
            {
                return;
            }

            if (SumTextBox.Text.Equals("0"))
            {
                SumTextBox.Text = number;
            }
            else
            {
                SumTextBox.Text += number;
            }
        }

        private void MakeLastOperation(double number)
        {
            switch (this._lastOperation)
            {
                case "+":
                    this._sum += number;
                    break;
                case "-":
                    this._sum -= number;
                    break;
                case "*":
                    this._sum *= number;
                    break;
                case "/":
                    if (number == 0)
                    {
                        MessageBox.Show("Nie możesz dzielić przez 0!");
                        this._sum = 0;
                        this._lastOperation = string.Empty;
                        break;
                    }
                    this._sum /= number;
                    break;
                default:
                    this._sum = double.Parse(SumTextBox.Text);
                    break;
            }

            string sum = this._sum.ToString();

            if (sum.Length > 20) 
            {
                sum = sum.Substring(0, 20);
                this._sum = double.Parse(sum);
            }
        }
    }
}
