using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    public class BestTimeToBuyStocks
    {
        public void Main()
        {
            Console.WriteLine(MaxProfit(new[] { 2, 4, 1 }));
        }

        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
                return 0;

            int min = prices[0];
            int diff = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }

                if (prices[i] - min > diff)
                {
                    diff = prices[i] - min;
                }
            }

            return diff;
        }
    }
}
