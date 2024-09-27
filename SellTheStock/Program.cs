
using SellTheStock;

MaxProfitClass maxProfitClass = new MaxProfitClass();

int[] prices1 = { 7, 1, 5, 3, 6, 4 };
Console.WriteLine("Max Profit: " + maxProfitClass.MaxProfit(prices1));  // Output: 5

// Example 2
int[] prices2 = { 7, 6, 4, 3, 1 };
Console.WriteLine("Max Profit: " + maxProfitClass.MaxProfit(prices2));  // Output: 0