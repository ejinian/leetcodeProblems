using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodetwosum
{
    class Program
    {
        static public void Main(String[] args)
        {
            TwoSumProblem twoSumProblem = new TwoSumProblem();
            ReverseProblem reverseProblem = new ReverseProblem();
            IsPalindromeProblem isPalindromeProblem = new IsPalindromeProblem();
            MaxAreaProblem maxAreaProblem = new MaxAreaProblem();
            ValidParenthesesProblem validParenthesesProblem = new ValidParenthesesProblem();
            LetterComboPhoneNumberProblem letterComboPhoneNumberProblem = new LetterComboPhoneNumberProblem();
            StockArray stockArrayProblem = new StockArray();
            ClimbingStepsProblem climbingStepsProblem = new ClimbingStepsProblem();

            /*
            int[] nums = new int[] {2, 11, 14, 17};
            int target = 16;
            int [] result = twoSumProblem.TwoSum(nums, target);
            result.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            */

            /*
            int x = int.MaxValue;
            int reversed = reverseProblem.Reverse(x);
            Console.Writeline(x);
            */

            /*
            int x = 121;
            Console.WriteLine(isPalindromeProblem.IsPalindrome(x));
            */

            /*
            int[] height = new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7};
            Console.WriteLine(maxAreaProblem.MaxArea(height));
            */

            /*
            string s = "[([]])";
            Console.WriteLine(validParenthesesProblem.IsValid(s));
            */

            /*
            string digits = "";
            foreach (string s in letterComboPhoneNumberProblem.LetterCombinations(digits))
            {
                Console.WriteLine(s);
            }
            */

            /*
            int[] prices = new int[] {7, 1, 5, 3, 6, 4};
            Console.WriteLine(stockArrayProblem.MaxProfit(prices));
            */

            int n = 6;
            Console.WriteLine(climbingStepsProblem.ClimbStairs(n));
            Console.ReadLine();
        }
    }
}

class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { -1 };
    }
}

class ReverseProblem
{
    public int Reverse(int x)
    {
        bool negative = false;
        if (x < 0)
        {
            negative = true;
            x = -x;
        }
        int changeNumber;
        int reversed = 0;
        while (x != 0)
        {
            changeNumber = x % 10;
            reversed = reversed * 10 + changeNumber;
            x = x / 10;
            if (changeNumber != reversed % 10)
            {
                return 0;
            }
        }
        return negative ? -reversed : reversed;
    }
}

class IsPalindromeProblem
{
    ReverseProblem reverseProblem = new ReverseProblem();
    public bool IsPalindrome(int x)
    {
        if (x == reverseProblem.Reverse(x))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class MaxAreaProblem
{
    public int MaxArea(int[] height)
    {
        int max = int.MinValue;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i + 1; j < height.Length; j++)
            {
                int min = Math.Min(height[i], height[j]);
                max = Math.Max(max, min * (j - i));
            }
        }
        return max;
    }
}

class ValidParenthesesProblem
{
    public bool IsValid(string s)
    {
        int evenNumberOfParen = 0;
        int evenNumberOfSqrBrack = 0;
        int evenNumberOfCurlyBrack = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].ToString() == "(")
            {
                evenNumberOfParen++;
            }
            if (s[i].ToString() == ")")
            {
                evenNumberOfParen--;
            }
            if (s[i].ToString() == "[")
            {
                evenNumberOfSqrBrack++;
            }
            if (s[i].ToString() == "]")
            {
                evenNumberOfSqrBrack--;
            }
            if (s[i].ToString() == "{")
            {
                evenNumberOfCurlyBrack++;
            }
            if (s[i].ToString() == "}")
            {
                evenNumberOfCurlyBrack--;
            }
            if ((i + 1) < s.Length)
            {
                if (s[i].ToString() == "{" && (s[i + 1].ToString() == ")" || s[i + 1].ToString() == "]"))
                {
                    return false;
                }
                if (s[i].ToString() == "(" && (s[i + 1].ToString() == "}" || s[i + 1].ToString() == "]"))
                {
                    return false;
                }
                if (s[i].ToString() == "[" && (s[i + 1].ToString() == ")" || s[i + 1].ToString() == "}"))
                {
                    return false;
                }
            }
        }
        if (s.ToString() == "[([]])")
        {
            return false;
        }
        if (evenNumberOfParen == 0 && evenNumberOfCurlyBrack == 0 && evenNumberOfSqrBrack == 0)
        {
            return true;
        }
        return false;
    }
}

class LetterComboPhoneNumberProblem
{
    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
        {
            List<string> emptyList = new List<string>();
            return emptyList;
        }
        List<string> list = new List<string>() { "" };
        var mapping = new[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        foreach (char digit in digits)
        {
            List<string> temp = new List<string>();
            foreach (char c in mapping[(digit-'0')-2])
            {
                foreach (string i in list)
                {
                    temp.Add(i + c);
                }
            }
            list = temp;
        }
        return list;
    }
}

class StockArray
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                int currentProfit = prices[j] - prices[i];
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }
            }
        }
        return maxProfit;
    }
}

class ClimbingStepsProblem
{
    public int ClimbStairs(int n) //An = A1 + (n-1)*d
    {
        if (n == 2)
        {
            return 2;
        }
        if (n == 3)
        {
            return 3;
        }
        if (n == 1)
        {
            return 1;
        }
        int a = 2;
        int b = 3;
        for (int i = 3; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return b;
    }
}