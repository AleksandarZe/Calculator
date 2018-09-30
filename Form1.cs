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
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        double values = 0;
        bool pressed = false;
        string operation = "";
        private void btnOne_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (pressed))
            {
                txtResult.Clear();
            }
            Button b = (Button)sender;

            if (b.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text += b.Text;
                }
            }
            else
            {
                txtResult.Text += b.Text;
            }
            pressed = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (values != 0)
            {
                btnEquals.PerformClick();
                pressed = true;
                operation = b.Text;
                lblCalculations.Text = values + " " + operation;

            }
            else
            {
                operation = b.Text;
                values = double.Parse(txtResult.Text);
                pressed = true;
                lblCalculations.Text = values + " " + operation;


            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblCalculations.Text = "";
            switch (operation)
            {
                case "+":txtResult.Text = (values + double.Parse(txtResult.Text)).ToString();break;
                case "-":txtResult.Text = (values - double.Parse(txtResult.Text)).ToString();break;
                case "*":txtResult.Text = (values * double.Parse(txtResult.Text)).ToString();break;
                case "/":txtResult.Text = (values / double.Parse(txtResult.Text)).ToString();break;
                default:break;
            }
            values = double.Parse(txtResult.Text);
            operation = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            operation = "";
            values = 0;
            txtResult.Text = "0";
        }

        private void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":btnZero.PerformClick();break;
                case "1":btnOne.PerformClick();break;
                case "2":btnTwo.PerformClick();break;
                case "3":btnThree.PerformClick();break;
                case "4":btnFour.PerformClick();break;
                case "5":btnFive.PerformClick();break;
                case "6":btnSix.PerformClick();break;
                case "7":btnSeven.PerformClick();break;
                case "8":btnEight.PerformClick();break;
                case "9":btnNine.PerformClick();break;
                case "+":btnPlus.PerformClick();break;
                case "-":btnMinus.PerformClick();break;
                case "*":btnTimes.PerformClick();break;
                case "/":btnDevide.PerformClick();break;
                case "=":btnEquals.PerformClick();break;
                case ".":btnComa.PerformClick();break;
                  
            }
        }
    }
}
