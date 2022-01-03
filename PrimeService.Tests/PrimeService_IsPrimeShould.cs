using System;
using Xunit;
using PrimeService;

namespace PrimeService.Tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly Prime _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new Prime();
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }
}
