using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    namespace Model
    {
        public enum Operations
        {
            Add, Sub, Mult,
            Div, Not, Sqrt,
            Mod, Reciproc, None, Equal
        };

        class CalculatorImpl : ICalculator
        {
            private double value;
            private string currentValue;
            private Operations currentOperation;

            public event OnResult onResult;

            private void updateResult()
            {
                if (this.onResult != null)
                    this.onResult(this.value.ToString("0.######"));
            }

            private void showError(String msg)
            {
                if (this.onResult != null)
                    this.onResult(msg);

                this.value = 0;
                this.currentValue = "";
                this.currentOperation = Operations.None;
            }

            private void compute(Operations operation)
            {
                if (this.currentValue != "")
                {
                    switch (this.currentOperation)
                    {
                        case Operations.None:
                            this.value = Convert.ToDouble(this.currentValue);
                            this.currentValue = "";
                            break;
                        case Operations.Add:
                            this.value += Convert.ToDouble(this.currentValue);
                            this.currentValue = "";
                            break;
                        case Operations.Sub:
                            this.value -= Convert.ToDouble(this.currentValue);
                            this.currentValue = "";
                            break;
                        case Operations.Mult:
                            this.value *= Convert.ToDouble(this.currentValue);
                            this.currentValue = "";
                            break;
                        case Operations.Div:
                            if (Convert.ToDouble(this.currentValue) != 0)
                            {
                                this.value /= Convert.ToDouble(this.currentValue);
                                this.currentValue = "";
                            }
                            else
                            {
                                this.showError("Division by zero");
                                return;
                            }
                            break;
                        case Operations.Mod:
                            if (Convert.ToDouble(this.currentValue) != 0)
                            {
                                this.value %= Convert.ToDouble(this.currentValue);
                                this.currentValue = "";
                            }
                            else
                            {
                                this.showError("Division by zero");
                                return;
                            }
                            break;
                    }
                }

                if (operation == Operations.Not)
                    this.value = -this.value;

                if (operation == Operations.Sqrt)
                {
                    if (this.value < 0)
                    {
                        this.showError("Negative root");
                        return;
                    } 
                    else
                        this.value = Math.Sqrt(this.value);
                }

                if (operation == Operations.Reciproc && this.value != 0)
                    this.value = 1 / this.value;

                if (operation == Operations.Equal)
                {
                    this.currentOperation = Operations.None;
                    if (this.onResult != null)
                        this.onResult(this.value.ToString("0.######"));
                } else
                    this.currentOperation = operation;

                this.updateResult();
            }

            public CalculatorImpl()
            {
                this.value = 0;
                this.currentValue = "";
                this.currentOperation = Operations.None;
            }

            public void setDigit(byte digit)
            {
                this.currentValue += digit.ToString();
                if (this.onResult != null)
                    this.onResult(this.currentValue);
            }

            public void setDot()
            {
                if (this.currentValue.Contains(",") == false)
                {
                    this.currentValue += ",";
                    if (this.onResult != null)
                        this.onResult(this.currentValue);
                }     
            }

            public void add()
            {
                this.compute(Operations.Add);
            }

            public void sub()
            {
                this.compute(Operations.Sub);
            }

            public void mult()
            {
                this.compute(Operations.Mult);
            }

            public void div()
            {
                this.compute(Operations.Div);
            }

            public void not()
            {
                this.compute(Operations.Not);
            }

            public void sqrt()
            {
                this.compute(Operations.Sqrt);
            }

            public void mod()
            {
                this.compute(Operations.Mod);
            }

            public void reciproc()
            {
                this.compute(Operations.Reciproc);
            }

            public void equal()
            {
                this.compute(Operations.Equal);
            }

            public void delete()
            {
                if (this.currentValue != "")
                {
                    this.currentValue = this.currentValue.Remove(currentValue.Length - 1);
                    if (this.onResult != null)
                    {
                        if (this.currentValue == "")
                            this.onResult("0");
                        else
                            this.onResult(this.currentValue);
                    }
                        
                }
            }

            public void clearAll()
            {
                this.value = 0;
                this.currentValue = "";
                this.currentOperation = Operations.None;
                if (this.onResult != null)
                    this.onResult("0");
            }

            public void clear()
            {
                this.currentValue = "";
                if (this.onResult != null)
                    this.onResult("0");
            }
        }
    }
}
