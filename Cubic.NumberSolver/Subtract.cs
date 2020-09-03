using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic.NumberSolver
{
    public class Subtract : IOperator
    {
        public  double Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
