﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic.NumberSolver
{
    public class Divide : IOperator
    {
        public double Calculate(int firstNumber, int secondNumber)
        {
            return secondNumber != 0 ? Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber) : default;
        }
    }
}
