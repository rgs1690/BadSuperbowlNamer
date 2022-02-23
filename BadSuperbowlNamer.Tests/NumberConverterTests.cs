using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class NumberConverterTests
    {
        [Fact] // xunit fact attribute - the following method is a unit test - is required that xunit will dectect this as a test
        public void Number_One_Is_Convertered_To_Roman_Numeral_Corecctly()
        {
            // test pass when no exceptions are thrown during the test
            //test fail when any exception is thrown 
            //throw new Exception("This test has failed");

            // Arrange => context that the test is run inside of , Given ...
            var numberToTest = 1;
            var expectedOutcome = "I";

            // Act => the actual thing we are testing, do this thing, when this happens...
            var actualOutcome = NumberConverter.Convert(1);
            // Assert lay out the expectations in such a way thatm, if not met, exceptions are thrown, then this happens...
            // Assert.Equal(expectedOutcome, actualOutcome);
            Assert.True(expectedOutcome == actualOutcome);
        
        }
    }
}