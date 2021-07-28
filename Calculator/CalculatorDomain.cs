using Calculator.Controllers;
using System;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorDomain : ICalculatorDomain
    {
        public async Task<int> Operation(Operation operation)
        {

            switch (operation.OperationType)
            {
                case OperationType.Sub:
                    return operation.FirstNumer - operation.SecondNumber;
                case OperationType.Sum:
                    return operation.FirstNumer + operation.SecondNumber;
                case OperationType.Mult:
                    return operation.FirstNumer * operation.SecondNumber;
                case OperationType.Div:
                    return operation.FirstNumer / operation.SecondNumber;
                default:
                    throw new Exception("The operation that are you trying to do is not implemented");
            }
        }
    }
}
