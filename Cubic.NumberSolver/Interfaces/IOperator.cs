using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic.NumberSolver
{
    public interface IOperator
    {
        double Calculate(int firstNumber, int secondNumber);
    }
}
