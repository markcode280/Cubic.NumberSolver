using Cubic.NumberSolver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic.NumberSolver.Interfaces
{
    public interface IExpression
    {
        string cleanExpression();
        string getOperator();

        IList<NumberExpression> GetAllExpressions(string Expression, IList<string> operatorList);
    }
}
