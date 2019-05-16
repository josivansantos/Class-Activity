using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerDivision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            decimal firstInteger;
            decimal secondInteger;
            decimal answer;

            flag = decimal.TryParse(txtFirstInteger.Text, out firstInteger);
            if (flag == false)
            {
                MessageBox.Show("The first value it´s not a number: " + txtFirstInteger.Text);
                return;
                }

            flag = decimal.TryParse(txtSecondInteger.Text, out secondInteger);
            if (flag == false)

            {
                MessageBox.Show("Enter the whole number", "imput error");
                txtSecondInteger.Focus();
                return;
            }
            answer = firstInteger / secondInteger;

            txtResult.Text = firstInteger.ToString() + " divided by " +
            secondInteger.ToString() + " equals " + answer.ToString();

            txtResult.Visible = true;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFirstInteger_TextChanged(object sender, EventArgs e)
        {

        }
    } }