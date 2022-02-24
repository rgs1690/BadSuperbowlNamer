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
            var converter = new NumberConverter();
            var actualOutcome = converter.Convert(numberToTest);
            // Assert lay out the expectations in such a way thatm, if not met, exceptions are thrown, then this happens...
             Assert.Equal(expectedOutcome, actualOutcome); // gives a better message when failure occurs
             // Assert.True(expectedOutcome == actualOutcome); // doesn't give a very good message when failure occurs. 
        
        }
        [Fact]
        public void Number_Four_Is_Converted_To_Roman_Numeral_Correctly()
        {
            //arrange
            var numbersToTest = 4;
            var expectedOutcome = "IV";
            //act
            var converter = new NumberConverter();
            var actualOutcome = converter.Convert(numbersToTest);

            //assert
            Assert.Equal(expectedOutcome, actualOutcome);

}


        //to debug a theory test with a specific set of inline data,
        //set your breakpoint, then right-click the specific test in the Test Explorer, and choose debug
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(1, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [Theory]
        public void Numbers_Can_Be_Converted_To_Roman_Numerals_Correctly(int numberToTest, string expectedOutcome )
        {
            ////arrange
            //numbersToTest = 4;
            //var expectedOutcome = "IV";
            //act
            var converter = new NumberConverter();
            var actualOutcome = converter.Convert(numberToTest);

            //assert
            Assert.Equal(expectedOutcome, actualOutcome);

        }

    }
}