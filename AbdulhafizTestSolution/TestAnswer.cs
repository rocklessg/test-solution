using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbdulhafizTestSolution
{
    public class TestAnswer
    {
        public static int RobberyAlertSum(int[] money)
        {
            var totalMoney = 0;
            for (int i = 0; i < money.Length; i++)
            {
                var indexIncrement = i + 1;
                //indexIncrement++;
                // Console.WriteLine(indexIncrement);
                if (indexIncrement % 2 != 0)
                {
                    totalMoney += money[i];
                }
            }
            return totalMoney;
        }

    }
}
