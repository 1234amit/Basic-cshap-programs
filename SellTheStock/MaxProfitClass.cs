using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellTheStock
{
    public class MaxProfitClass
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach(int price in prices)
            {
                if(price < minPrice)
                {
                    minPrice = price;
                }
                else
                {
                    int profit = price - minPrice;
                    if(profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }
    }
}
