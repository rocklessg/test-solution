namespace AbdulhafizTestSolution.UnitTest
{
    public class TestAnswerTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 1 })]
        [InlineData(new[] { 3, 2, 1, 3 })]
        [InlineData(new[] { 2, 2, 2, 1 })]
        [InlineData(new[] { 1, 7, 3, 3 })]
        public void MaximumRobberyAlertSum_ShouldReturnCorrectOutput_WhenInputValidData(int[] testCases)
        {
            // Arrange
            var moneyToBeRobbed = testCases;
            var expectedResult = 4;

            // Act
            var actualResult = TestAnswer.MaximumRobberyAlertSum(moneyToBeRobbed);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void MaximumRobberyAlertSum_ShouldReturnActualResult_WhenExpectedResultIsDifferentFromTheActualResult()
        {
            // Arrange
            var moneyToBeRobbed = new[] { 1, 2, 3, 1 };
            var expectedResult = 10;

            // Act
            var actualResult = TestAnswer.MaximumRobberyAlertSum(moneyToBeRobbed);

            // Assert
            Assert.NotEqual(expectedResult, actualResult);
        }

        #region Test for the uptimized version of the Test answer

        [Theory]
        [InlineData(new[] { 2, 7, 9, 3, 1 })]
        [InlineData(new[] { 9, 7, 2, 3, 1 })]
        [InlineData(new[] { 2, 7, 1, 3, 9 })]
        [InlineData(new[] { 1, 7, 9, 3, 2 })]
        public void MaximumRobberyAlertSumV2_ShouldReturnCorrectOutput_WhenInputValidData(int[] testCases)
        {
            // Arrange
            var moneyToBeRobbed = testCases;
            var expectedResult = 12;

            // Act
            var actualResult = TestAnswer.MaximumRobberyAlertSumV2(moneyToBeRobbed);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void MaximumRobberyAlertSumV2_ShouldReturnActualResult_WhenExpectedResultIsDifferentFromTheActualResult()
        {
            // Arrange
            var moneyToBeRobbed = new[] { 1, 2, 3, 1 };
            var expectedResult = 10;

            // Act
            var actualResult = TestAnswer.MaximumRobberyAlertSumV2(moneyToBeRobbed);

            // Assert
            Assert.NotEqual(expectedResult, actualResult);
        }

        #endregion
    }
}