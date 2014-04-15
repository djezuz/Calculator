using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Calculator.Model;

namespace Calculator
{
    namespace UI
    {
        public partial class FCalculator : Form
        {
            private ICalculator calculator;

            private void onResult(string result)
            {
                this.lResult.Text = result;
            }

            public FCalculator()
            {
                InitializeComponent();

                this.calculator = CalculatorFactory.getInstance();
                this.calculator.onResult += this.onResult;

                this.pbResult.Controls.Add(this.lResult);
                this.lResult.Location = new Point(12, 20);
            }

            private void insertNumber(object sender, EventArgs e)
            {
                byte digit = Convert.ToByte(((Button)sender).Text);
                this.calculator.setDigit(digit);
            }

            private void insertDot(object sender, EventArgs e)
            {
                this.calculator.setDot();
            }

            private void add(object sender, EventArgs e)
            {
                this.calculator.add();
            }

            private void equal(object sender, EventArgs e)
            {
                this.calculator.equal();
            }

            private void sub(object sender, EventArgs e)
            {
                this.calculator.sub();
            }

            private void mult(object sender, EventArgs e)
            {
                this.calculator.mult();
            }

            private void div(object sender, EventArgs e)
            {
                this.calculator.div();
            }

            private void not(object sender, EventArgs e)
            {
                this.calculator.not();
            }

            private void reciproc(object sender, EventArgs e)
            {
                this.calculator.reciproc();
            }

            private void mod(object sender, EventArgs e)
            {
                this.calculator.mod();
            }

            private void sqrt(object sender, EventArgs e)
            {
                this.calculator.sqrt();
            }

            private void clearAll(object sender, EventArgs e)
            {
                this.calculator.clearAll();
            }

            private void clear(object sender, EventArgs e)
            {
                this.calculator.clear();
            }

            private void delete(object sender, EventArgs e)
            {
                this.calculator.delete();
            }

            private void OnKeyDown(object sender, KeyEventArgs e)
            {
                switch(e.KeyData)
                {
                    case Keys.NumPad0:
                    case Keys.D0:
                        this.calculator.setDigit(0);
                        break;
                    case Keys.NumPad1:
                    case Keys.D1:
                        this.calculator.setDigit(1);
                        break;
                    case Keys.NumPad2:
                    case Keys.D2:
                        this.calculator.setDigit(2);
                        break;
                    case Keys.NumPad3:
                    case Keys.D3:
                        this.calculator.setDigit(3);
                        break;
                    case Keys.NumPad4:
                    case Keys.D4:
                        this.calculator.setDigit(4);
                        break;
                    case Keys.NumPad5:
                    case Keys.D5:
                        this.calculator.setDigit(5);
                        break;
                    case Keys.NumPad6:
                    case Keys.D6:
                        this.calculator.setDigit(6);
                        break;
                    case Keys.NumPad7:
                    case Keys.D7:
                        this.calculator.setDigit(7);
                        break;
                    case Keys.NumPad8:
                    case Keys.D8:
                        this.calculator.setDigit(8);
                        break;
                    case Keys.NumPad9:
                    case Keys.D9:
                        this.calculator.setDigit(9);
                        break;
                    case Keys.Decimal:
                        this.calculator.setDot();
                        break;
                    case Keys.Add:
                        this.calculator.add();
                        break;
                    case Keys.Subtract:
                        this.calculator.sub();
                        break;
                    case Keys.Multiply:
                        this.calculator.mult();
                        break;
                    case Keys.Divide:
                        this.calculator.div();
                        break;
                    case Keys.Return:
                        this.calculator.equal();
                        break;
                    case Keys.Back:
                        this.calculator.delete();
                        break;
                }
            }

        }
    }
}
