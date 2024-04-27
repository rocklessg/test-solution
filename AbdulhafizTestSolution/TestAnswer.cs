namespace AbdulhafizTestSolution
{
    public class TestAnswer
    {
        /* These numbers are used to avoid the use of (magic) numbers all over the code.
           This ensures that all constant numbers are easily located and make changing them easy if there is need.
           This practice is more useful in a large project.
        */
        private const int zero = 0;
        private const int one = 1;
        private const int two = 2;
        public static int MaximumRobberyAlertSum(int[] moneyInTheProspectiveHousesToRob)
        {
            var totalAmountRobbed = zero;
            for (int index = zero; index < moneyInTheProspectiveHousesToRob.Length; index++)
            {
                var indexIncrement = index + one;
                if (indexIncrement % two != zero)
                {
                    totalAmountRobbed += moneyInTheProspectiveHousesToRob[index];
                }
            }
            return totalAmountRobbed;
        }


        /* This uptimized version is done to demonstrate my progressive thinking
         * along when solving a problem and thriving to deliver a better perfomance software.
         */
        public static int MaximumRobberyAlertSumV2(int[] moneyInTheProspectiveHousesToRob)
        {
            var totalAmountRobbed = zero;
            for (int index = zero; index < moneyInTheProspectiveHousesToRob.Length; index += two)
            {
                totalAmountRobbed += moneyInTheProspectiveHousesToRob[index];
            }
            return totalAmountRobbed;
        }
    }
}
