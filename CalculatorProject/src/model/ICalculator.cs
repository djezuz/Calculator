using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    namespace Model
    {
        public delegate void OnOperation(string operation);
        public delegate void OnResult(string result);

        public interface ICalculator
        {
            event OnResult onResult;
            event OnOperation onOperation;

            void setDigit(byte digit);
            void setDot();

            void add();
            void sub();
            void mult();
            void div();
            void not();
            void sqrt();
            void mod();
            void reciproc();
            void equal();

            void delete();
            void clearAll();
            void clear();
        }

    }
}
