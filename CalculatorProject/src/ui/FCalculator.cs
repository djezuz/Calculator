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

            private void onOperation(string operation)
            {

            }

            public FCalculator()
            {
                InitializeComponent();

                this.calculator = CalculatorFactory.getInstance();
                this.calculator.onResult += this.onResult;
                this.calculator.onOperation += this.onOperation;

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

        }
    }
}
