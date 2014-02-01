using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            public event OnOperation onOperation;

            private void compute(Operations operation)
            {
                switch(this.currentOperation)
                {
                    case Operations.None:
                        this.value = Convert.ToDouble(this.currentValue);
                        this.currentValue = "";
                        break;
                    case Operations.Add:
                        this.value += Convert.ToDouble(this.currentValue);
                        //this.currentValue = "";
                        if (this.onResult != null)
                            this.onResult(this.value.ToString("0.######"));
                        break;
                    case Operations.Equal:
                        break;
                }

                /*
                this.currentOperation = operation;
                if (this.currentOperation == Operations.Equal)
                {
                    if (this.onResult != null)
                        this.onResult(this.value.ToString("0.######"));
                    this.currentOperation = Operations.None;
                }*/
                if (operation == Operations.Equal)
                {
                    if (this.onResult != null)
                        this.onResult(this.value.ToString("0.######"));
                } else
                    this.currentOperation = operation;


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
                this.currentValue = this.currentValue.Remove(currentValue.Length - 1);
                if (this.onResult != null)
                    this.onResult(this.currentValue);
            }

            public void clearAll()
            {
                // Delete history
                this.value = 0;
                this.currentValue = "";
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
