using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationsController : ControllerBase
    {
        private readonly ICalculatorDomain _calculatorDomain;
        private readonly ILogger<OperationsController> _logger;

        public OperationsController(ILogger<OperationsController> logger, ICalculatorDomain calculatorDomain)
        {
            _logger = logger;
            _calculatorDomain = calculatorDomain;
        }
        /// <summary>
        /// Make an operation with two ints
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Operation
        ///     {
        ///        "FirstNumer": 1,
        ///        "SecondNumer": 1,
        ///        "OperationType": 1 -> 0 Sum, 1, Sub, 2 Division, 3 Multiplication
        ///        
        ///     }
        ///
        /// </remarks>
        /// <param name="operation"></param>  
        /// <returns>The int result</returns>
        /// <response code="200">Return int operation result</response>
        [HttpPost]
        public async Task<int> Get(Operation operation)
        {
            return await _calculatorDomain.Operation(operation);
        }
    }
}
