using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    namespace Model
    {
        public class CalculatorFactory
        {
            private static volatile ICalculator instance = null;
            private static readonly object padlock = new object();

            public static ICalculator getInstance()
            {
                if (instance == null)
                {
                    lock(padlock)
                    {
                        Type t = Type.GetType(Properties.Settings.Default.CalculatorFactory + ", Calculator");
                        if (t == null)
                            throw new SystemException("Could not load the type: " +
                                Properties.Settings.Default.CalculatorFactory + ", Calculator");
                        else
                            instance = Activator.CreateInstance(t) as ICalculator;
                    }
                }

                return instance;
            }
        }
    }
}
