using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzKataTest
{
    [TestFixture]
    public class FizzBuzzKataTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "1")]
        [TestCase(2,"2")]
        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(9, "Fizz")]

        public void should_return_input_in_string(int input, string expectedResult)
        {
            
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Compute(input);
            Assert.AreEqual(expectedResult, result);


        }


/*

        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]

        public void should_return_Fizz_when_input_is_3(int input, string expectedResult)
        {

            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Compute(input);
            Assert.AreEqual(expectedResult, result);


        }


        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]

        public void should_return_Buzz_when_input_is_5(int input, string expectedResult)
        {

            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Compute(input);
            Assert.AreEqual(expectedResult, result);


        }

      
        [TestCase(15, "FizzBuzz")]

        public void should_return_FizzBuzz_when_input_is_5_and_3(int input, string expectedResult)
        {

            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Compute(input);
            Assert.AreEqual(expectedResult, result);


        }*/
    }
}