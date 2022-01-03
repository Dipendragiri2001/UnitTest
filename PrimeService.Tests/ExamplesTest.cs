using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace PrimeService.Tests
{
    public class ExamplesTest
    {
        [Fact]
        public void ExampleLoadTextFile_ValidName()
        {
            string actual = Examples.ExampleLoadTextFile("This is valid");

            Assert.True(actual.Length > 0);
        }
        [Fact]
        public void ExampleLoadTextFile_InvalidNameFail()
        {
            Assert.Throws<ArgumentException>("file", () => Examples.ExampleLoadTextFile(""));
        }

    }
}