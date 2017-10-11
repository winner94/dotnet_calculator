using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        // variable
        string firstNumber;
        string secondNumber;
        char actionType = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnEquation_Click(object sender, EventArgs e)
        {  
            switch (actionType)
            {
                case('+'):
                    txtResult.Text = (int.Parse(firstNumber) + int.Parse(secondNumber)).ToString();
                    //MessageBox.Show("Typ:" + actionType.ToString() + ".\nA= " + firstNumber.ToString() + "\nB=" + secondNumber.ToString());
                    //int result = (int.Parse(firstNumber) + int.Parse(secondNumber));
                    //txtResult.Text = result.ToString();
                    break;
                case ('-'):
                    txtResult.Text = (int.Parse(firstNumber) - int.Parse(secondNumber)).ToString();
                    break;
                case ('*'):
                    txtResult.Text = (int.Parse(firstNumber) * int.Parse(secondNumber)).ToString();
                    break;
                case ('/'):
                    if (secondNumber == "0")
                    {
                        txtResult.Text = "Działanie zabronione! Nie można dzielić przez zero";
                    }
                    txtResult.Text = (int.Parse(firstNumber) / int.Parse(secondNumber)).ToString();
                    break;

                    firstNumber = txtResult.Text; 
                    secondNumber = "";
                    actionType = ' ';
            }
        }

        private void btmAddition_Click(object sender, EventArgs e)
        {
            actionType = '+';
            txtResult.Text = "";
            /*
                txtResult.Clear();
                po kliknięciu w przycisk do textBox nie są dopisywane kolejne cyfry
            */

        }
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            actionType = '-';
            txtResult.Text = "";
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            actionType = '*';
            txtResult.Text = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            actionType = '/';
            txtResult.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnNumberNine_Click(object sender, EventArgs e)
        {
            Equation(9);
        }

        private void btnNumberEight_Click(object sender, EventArgs e)
        {
            Equation(8);
        }      

        private void btnNumberThree_Click(object sender, EventArgs e)
        {
            Equation(3);
        }

        private void btnNumberSix_Click(object sender, EventArgs e)
        {
            Equation(6);
        }


        private void btnNumberZero_Click(object sender, EventArgs e)
        {
            Equation(0);
        }

        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            Equation(2);
        }

        private void btnNumberOne_Click(object sender, EventArgs e)
        {
            Equation(1);
        }

        private void btnNumberFive_Click(object sender, EventArgs e)
        {
            Equation(5);
        }

        private void btnNumberFour_Click(object sender, EventArgs e)
        {
            Equation(4);
        }

        private void btnNumberSeven_Click(object sender, EventArgs e)
        {
            Equation(7);
        }    

        private void Equation(int a)
        {
            if (actionType == ' ')
            {
                firstNumber += a;
                txtResult.Text = firstNumber;
            }
            else
            {
                secondNumber += a;
                txtResult.Text += a;
            }
            
        }
    }
}
