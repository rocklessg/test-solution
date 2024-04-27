namespace AbdulhafizTestSolution.UnitTest
{
    public class TestAnswerTest
    {
        [Fact]
        public void MaximumRobberyAlertSum_ShouldReturnCorrectOutput_WhenValidDataArePassed()
        {
            // Arrange
            var moneyToBeRobbed = new[] { 1, 2, 3, 1 };

            // Act
            var result = TestAnswer.MaximumRobberyAlertSum(moneyToBeRobbed);

            // Assert
            Assert.Equal(4, result);
        }
    }
}