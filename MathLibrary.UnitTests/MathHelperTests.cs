using NUnit.Framework;

namespace MathLibrary.UnitTests
{
    public class Tests
    {
        //{MethodName}_{WhenCondition}_{ShouldExeptedResult}
        [TestCase(5, 7, 10, 10)]//parameters
        [TestCase(5, 10, 3, 10)]
        [TestCase(10, 7, 1, 10)]
        [TestCase(-5, -7, -10, -5)]
        public void Max_WhenCalled_ShouldFindMaxValue(int a, int b, int c, int expectedResult)
        {
            //Arrange

            //Act
            int actualResult = MathHalper.Max(a, b, c);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Positive case :
        //Arrange
        [TestCase(new[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new[] { 1, 4, 3, 1 }, 4)]
        [TestCase(new[] { 4, 2, 3, 1 }, 4)]
        [TestCase(new[] { 0 }, 0)]
        [TestCase(new[] { -5, -7 }, -5)]

        public void Max_WhenArrayFilled_ShouldFindMaxValue(int[] sourceArray, int expectedResult)
        {
            //Act
            var actualResult = MathHalper.Max(sourceArray);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Negative case :
        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Max_WhenArrayEmptyOrNull_ShouldThrowArgumentException(int[] sourceArray)
        {
            try
            {
                MathHalper.Max(sourceArray);
            }
            catch 
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}