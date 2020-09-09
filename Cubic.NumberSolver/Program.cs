using Cubic.NumberSolver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic.NumberSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter Input: ");
            var Expression=Console.ReadLine();
            ProccessNumbers("* 12.4 + 4 - 3 / 5 =");
        }

        public static void ProccessNumbers(string Expression)
        {
            try
            {
                IOperator operatorObj = null;
                IExpression expressionService = new ExpressionService(Expression);

                var expression = expressionService.cleanExpression();
                var allExprressions = expressionService.GetAllExpressions(expression, new List<string> { "/", "*", "+", "-" });

                double result = 0;

                foreach (var exp in allExprressions)
                {
                    switch (exp.Operator)
                    {
                        case "+":
                            operatorObj = new Addition();
                            break;
                        case "-":
                            operatorObj = new Subtract();
                            break;
                        case "/":
                            operatorObj = new Divide();
                            break;
                        case "*":
                            operatorObj = new Multiply();
                            break;
                    }
                    result += operatorObj.Calculate(exp.FirstNumber, exp.SecondNumber);
                }
            }
            catch(Exception e)
            {

            }
                  
        }
    }
}
