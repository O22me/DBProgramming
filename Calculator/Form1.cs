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

            InitVariables();
        }
        #region 변수, 연산자 초기화
        public void InitVariables()
        {
            //comboBox 연산자 초기화
            comboBoxComboCalc_Operators.Items.Clear();

            comboBoxComboCalc_Operators.Items.Add("+");
            comboBoxComboCalc_Operators.Items.Add("-");
            comboBoxComboCalc_Operators.Items.Add("*");
            comboBoxComboCalc_Operators.Items.Add("/");
            comboBoxComboCalc_Operators.SelectedIndex = 0;

            //RadioBox 연산자 초기화
            radioButtonRadioButtonPlus.Checked = true;
            //SquareRoot 연산자 초기화
            radioButtonSquareRootPlus.Checked = true;
        }
        #endregion
        public char RadioButtonCheckedOperator()
        {
            if (radioButtonRadioButtonPlus.Checked)
            {
                return '+';
            }
            else if (radioButtonRadioButtonMinus.Checked)
            {
                return '-';
            }
            else if (radioButtonRadioButtonMultiply.Checked)
            {
                return '*';
            }
            else if (radioButtonRadioButtonDivision.Checked)
            {
                return '/';
            }
            else return ' ';
        }
        public char SquareRootCheckedOperator()
        {
            if (radioButtonSquareRootPlus.Checked)
            {
                return '+';
            }
            else if (radioButtonSquareRootMInus.Checked)
            {
                return '-';
            }
            else if (radioButtonSquareRootMultiply.Checked)
            {
                return '*';
            }
            else if (radioButtonSquareRootDivision.Checked)
            {
                return '/';
            }
            else return ' ';
        }

        private void buttonComboBoxCalculate_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(textBoxComboBoxOperand1.Text);
            double operand2 = Convert.ToDouble(textBoxComboBoxOperand2.Text);

            switch (comboBoxComboCalc_Operators.SelectedIndex)
            {
                case 0: // +
                    textBoxComboBoxResult.Text = Convert.ToString(operand1 + operand2);
                    break;
                case 1: // -
                    textBoxComboBoxResult.Text = Convert.ToString(operand1 - operand2);
                    break;
                case 2: // *
                    textBoxComboBoxResult.Text = Convert.ToString(operand1 * operand2);
                    break;
                case 3: // /
                    textBoxComboBoxResult.Text = Convert.ToString(operand1 / operand2);
                    break;
            }
        }

        private void textBoxRadioButtonOperand1_TextChanged(object sender, EventArgs e)
        {
            textBoxRadioButtonResult.Text = textBoxRadioButtonOperand1.Text + RadioButtonCheckedOperator() + textBoxRadioButtonOperand2.Text;
        }

        private void textBoxRadioButtonOperand2_TextChanged(object sender, EventArgs e)
        {
            textBoxRadioButtonResult.Text = textBoxRadioButtonOperand1.Text + RadioButtonCheckedOperator() + textBoxRadioButtonOperand2.Text;
        }

        private void radioButtonRadioButtonPlus_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRadioButtonResult.Text = textBoxRadioButtonOperand1.Text + RadioButtonCheckedOperator() + textBoxRadioButtonOperand2.Text;
        }

        private void radioButtonRadioButtonMinus_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRadioButtonResult.Text = textBoxRadioButtonOperand1.Text + RadioButtonCheckedOperator() + textBoxRadioButtonOperand2.Text;
        }

        private void radioButtonRadioButtonMultiply_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRadioButtonResult.Text = textBoxRadioButtonOperand1.Text + RadioButtonCheckedOperator() + textBoxRadioButtonOperand2.Text;
        }

        private void radioButtonRadioButtonDivision_CheckedChanged(object sender, EventArgs e)
        {
            textBoxRadioButtonResult.Text = textBoxRadioButtonOperand1.Text + RadioButtonCheckedOperator() + textBoxRadioButtonOperand2.Text;
        }

        private void buttonRadioButtonCalculate_Click(object sender, EventArgs e)
        {
            //Split을 통한 피연산자와 연산자 분리
            String[] split_operand = textBoxRadioButtonResult.Text.Split(RadioButtonCheckedOperator());
            double operand1 = Convert.ToDouble(split_operand[0]);
            double operand2 = Convert.ToDouble(split_operand[1]);

            //char형도 정수자료형이므로 switch문 사용가능
            switch (RadioButtonCheckedOperator())
            {
                case '+':
                    textBoxRadioButtonResult.Text = Convert.ToString(operand1 + operand2);
                    break;
                case '-':
                    textBoxRadioButtonResult.Text = Convert.ToString(operand1 - operand2);
                    break;
                case '*':
                    textBoxRadioButtonResult.Text = Convert.ToString(operand1 * operand2);
                    break;
                case '/':
                    textBoxRadioButtonResult.Text = Convert.ToString(operand1 / operand2);
                    break;
            }
        }

        private void buttonSquareRootCalculate_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(textBoxSquareRootOperand1.Text);
            double operand2 = Convert.ToDouble(textBoxSquareRootOperand2.Text);

            if (checkBoxSquareRootOperand1SqrtCheck.Checked)
            {
                operand1 = Math.Sqrt(operand1);
            }
            if (checkBoxSquareRootOperand2SqrtCheck.Checked)
            {
                operand2 = Math.Sqrt(operand2);
            }

            switch(SquareRootCheckedOperator())
            {
                case '+':
                    textBoxSquareRootResult.Text = Convert.ToString(operand1 + operand2);
                    break;
                case '-':
                    textBoxSquareRootResult.Text = Convert.ToString(operand1 - operand2);
                    break;
                case '*':
                    textBoxSquareRootResult.Text = Convert.ToString(operand1 * operand2);
                    break;
                case '/':
                    textBoxSquareRootResult.Text = Convert.ToString(operand1 / operand2);
                    break;
            }
        }
    }
}
