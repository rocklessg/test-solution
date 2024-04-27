namespace AbdulhafizTestSolution
{
    public class TestAnswer
    {
        private const int magicNumberZero = 0;
        private const int magicNumberOne = 1;
        private const int magicNumberTwo = 2;
        public static int MaximumRobberyAlertSum(int[] moneyInTheProspectiveHousesToRob)
        {
            var totalAmountRobbed = magicNumberZero;
            for (int cash = magicNumberZero; cash < moneyInTheProspectiveHousesToRob.Length; cash++)
            {
                var indexIncrement = cash + magicNumberOne;
                if (indexIncrement % magicNumberTwo != magicNumberZero)
                {
                    totalAmountRobbed += moneyInTheProspectiveHousesToRob[cash];
                }
            }
            return totalAmountRobbed;
        }
    }
}
