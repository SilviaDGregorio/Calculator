using Calculator.Controllers;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculatorDomain
    {
        Task<int> Operation(Operation operation);
    }
}