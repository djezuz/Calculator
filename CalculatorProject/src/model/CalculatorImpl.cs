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
            Mod, Reciproc, None
        };


        class CalculatorImpl : ICalculator
        {
            private double value;
            private string currentValue;
            private Operations currentOperation;

            public event OnResult onResult;
            public event OnOperation onOperation;

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
                
            }

            public void sub()
            {
                throw new NotImplementedException();
            }

            public void mult()
            {
                throw new NotImplementedException();
            }

            public void div()
            {
                throw new NotImplementedException();
            }

            public void not()
            {
                throw new NotImplementedException();
            }

            public void sqrt()
            {
                throw new NotImplementedException();
            }

            public void mod()
            {
                throw new NotImplementedException();
            }

            public void reciproc()
            {
                throw new NotImplementedException();
            }

            public void equal()
            {
                throw new NotImplementedException();
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
