using System.Threading.Tasks;
using Xunit;

namespace Calculator.Domain.Test
{
    public class CalculatorDomainTest
    {
        private readonly CalculatorDomain _calculator;

        public CalculatorDomainTest()
        {
            _calculator = new CalculatorDomain();
        }

        [Fact]
        public async Task Given_sum_Then_Works()
        {
            var result = await _calculator.Operation(new Controllers.Operation()
            {
                FirstNumer = 1,
                SecondNumber = 1,
                OperationType = Controllers.OperationType.Sum
            });

            Assert.Equal(2, result);

        }

        [Fact]
        public async Task Given_sub_Then_Works()
        {
            var result = await _calculator.Operation(new Controllers.Operation()
            {
                FirstNumer = 1,
                SecondNumber = 1,
                OperationType = Controllers.OperationType.Sub
            });

            Assert.Equal(0, result);
        }

        [Fact]
        public async Task Given_mult_Then_Works()
        {
            var result = await _calculator.Operation(new Controllers.Operation()
            {
                FirstNumer = 2,
                SecondNumber = 5,
                OperationType = Controllers.OperationType.Mult
            });

            Assert.Equal(10, result);
        }

        [Fact]
        public async Task Given_div_Then_Works()
        {
            var result = await _calculator.Operation(new Controllers.Operation()
            {
                FirstNumer = 10,
                SecondNumber = 2,
                OperationType = Controllers.OperationType.Div
            });

            Assert.Equal(5, result);
        }
    }
}
