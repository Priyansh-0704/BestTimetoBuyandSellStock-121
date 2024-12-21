public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0, bestBuy = int.MaxValue;
        for(int i = 0; i < prices.Length; i++)
        {
            bestBuy = int.Min(prices[i], bestBuy); // finding the minimum possible buy price
            maxProfit = int.Max(maxProfit, prices[i] - bestBuy); // finding the largest possible difference b/w sell and buy
        }
        return maxProfit;
    }
}
