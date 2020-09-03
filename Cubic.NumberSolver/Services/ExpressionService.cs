using Cubic.NumberSolver.Interfaces;
using Cubic.NumberSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cubic.NumberSolver
{
    public class ExpressionService: IExpression
    {
        private readonly string _expression;
        public ExpressionService(string Expression)
        {
            _expression = Expression;
        }

        public string cleanExpression()
        {
            return string.Join("", _expression.Skip(1).Reverse().Skip(1).Reverse()).Replace(" ","");
        }

        public string getOperator()
        {
            return _expression.Skip(1).FirstOrDefault().ToString();
        }
        public IList<NumberExpression> GetAllExpressions(string Expression,IList<string> operatorList)
        {
            string pattern = "["+string.Join("", operatorList) + "]";
            var numberExpressions = new List<NumberExpression>();
            // var regex = new Regex(pattern);
            var countOFNumbers = Regex.Split(Expression, pattern);
            int count = 0;

            while (count  < countOFNumbers.Length-1)
            {
                var numberExpressionObj = new NumberExpression();
                numberExpressionObj.FirstNumber = int.Parse(countOFNumbers[count++]);
                numberExpressionObj.Operator = Expression[Expression.IndexOf(numberExpressionObj.FirstNumber.ToString()) + 1].ToString();
                numberExpressionObj.SecondNumber = int.Parse(countOFNumbers[count++]);
                numberExpressions.Add(numberExpressionObj);
                count = count - 1;
            }

            return numberExpressions;
        }
    }
}
