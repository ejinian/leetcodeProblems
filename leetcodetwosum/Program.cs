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
            RemoveElementTypeProblem removeElementTypeProblem = new RemoveElementTypeProblem();
            ValidAnagram validAnagramProblem = new ValidAnagram();
            ProductOfArrayExceptSelfProblem productOfArrayExceptSelfProblem = new ProductOfArrayExceptSelfProblem();
            SearchInsertPosition searchInsertPositionProblem = new SearchInsertPosition();
            RomanToIntt romanToIntProblem = new RomanToIntt();
            FoobarProblems foobarProblems = new FoobarProblems();
            JumpGame jumpGame = new JumpGame();
            RobbingHouses robbingHouses = new RobbingHouses();
            Power power = new Power();
            MoveZeroesProblem moveZeroes = new MoveZeroesProblem();
            IsSubsequenceProblem isSubsequence = new IsSubsequenceProblem();

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

            /*
            int n = 6;
            Console.WriteLine(climbingStepsProblem.ClimbStairs(n));
            */

            /*
            int[] nums = new int[] { 3, 2, 2, 3 };
            int val = 3;
            Console.WriteLine(removeElementTypeProblem.RemoveElement(nums, val));
            */

            /*
            string s = "rat";
            string t = "car";
            Console.WriteLine(validAnagramProblem.IsAnagram(s, t));
            */

            /*
            int[] nums = new int[] { 1, 2, 3, 4 };
            int[] result = productOfArrayExceptSelfProblem.ProductExceptSelf(nums);
            result.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            */

            /*
            int[] nums = new int[] { 2, 3, 5, 6 };
            int target = 4;
            Console.WriteLine(searchInsertPositionProblem.SearchInsert(nums, target));
            */

            /*
            string b = "X";
            Console.WriteLine(romanToIntProblem.RomanToInt(b));
            */

            /*
            string[] strs = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(longestPrefixProblem.LongestCommonPrefix(strs));
            */

            /*
            List<int> x = new List<int>() { 14, 27, 1, 4, 2, 50, 3, 1 };
            List<int> y = new List<int>() { 2, 4, -4, 3, 1, 1, 14, 27, 50 };
            Console.WriteLine(foobarProblems.Solution1(x, y));
            */

            /*
            Console.WriteLine(foobarProblems.Solution2(90, 7));
            */

            /*
            Console.WriteLine(foobarProblems.Solution3(0, 1));
            */

            /*
            Console.WriteLine(foobarProblems.Solution4(2, 1));
            */

            /*
            int[] nums = new int[] {1, 0, 8, 2, 0, 0, 1 };
            Console.WriteLine(jumpGame.CanJump(nums));
            */

            /*
            int[] nums = new int[] {1, 3, 6, 3, 1, 1, 1, 1, 2 };
            Console.WriteLine(robbingHouses.RobHouse(nums));
            */

            /* recursion practice:::::::::
            Console.WriteLine(robbingHouses.Factorial(5));
            Console.WriteLine(robbingHouses.PowerTo(7, 2));
            Console.WriteLine(robbingHouses.SumTillN(10));
            Console.WriteLine(robbingHouses.Multiply(10, 5));
            Console.WriteLine(robbingHouses.PowerToNegativeInt(3, -2));
            */

            /*
            Console.WriteLine(power.IsPowerOfTwo(0));
            Console.WriteLine(power.IsPowerOfThree(27));
            Console.WriteLine(power.IsHappy(19));
            Console.WriteLine(power.AddDigits(38));
            */

            /*
            int[] nums = new int[] { 0, 1, 0, 3, 12 };
            Console.WriteLine(moveZeroes.MoveZeroes(nums));
            */

            Console.WriteLine(isSubsequence.IsSubsequence("bb", "abbc"));
            Console.WriteLine(isSubsequence.CanConstruct("aab", "baa"));

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
            foreach (char c in mapping[(digit - '0') - 2])
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

class RemoveElementTypeProblem
{
    public int RemoveElement(int[] nums, int val)
    {
        //   0  1  2  3
        // { 3, 2, 2, 3}
        int i = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] != val)
            {
                nums[i] = nums[j];
                i++;
            }
        }
        return i;
    }
}

class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        char[] charArray = s.ToCharArray();
        char[] charArray2 = t.ToCharArray();
        Array.Sort(charArray);
        Array.Sort(charArray2);
        string turnBackS = new string(charArray);
        string turnBackT = new string(charArray2);
        if (string.Equals(turnBackS, turnBackT))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}

class ProductOfArrayExceptSelfProblem
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int largestNumberSoFar = 0;
        int leastCommonMultiple = 0;
        int storeValueToDivide = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > largestNumberSoFar)
            {
                largestNumberSoFar = nums[i];
            }
        }

        for (int j = 0; j < nums.Length; j++)
        {
            if (largestNumberSoFar % nums[j] != 0)
            {
                largestNumberSoFar++;
                j = 0;
                j--;
            }
            else
            {
                leastCommonMultiple = largestNumberSoFar;
            }
        }

        int[] arrayWithNewValues = new int[nums.Length];
        for (int k = 0; k < nums.Length; k++)
        {
            storeValueToDivide = leastCommonMultiple / nums[k];
            arrayWithNewValues[k] = storeValueToDivide;
        }
        return arrayWithNewValues;
    }
}

class SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        int largeChecker = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (target > nums[i] && target < nums[j])
                {
                    return i + 1;
                }
                i++;
            }
            largeChecker = nums[nums.Length - 1];
        }
        if (target > largeChecker)
        {
            return nums.Length;
        }
        return 0;
    }
}

class RomanToIntt
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> My_dict = new Dictionary<char, int>();
        My_dict.Add('I', 1);
        My_dict.Add('V', 5);
        My_dict.Add('X', 10);
        My_dict.Add('L', 50);
        My_dict.Add('C', 100);
        My_dict.Add('D', 500);
        My_dict.Add('M', 1000);
        int t = 0;
        int o = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (My_dict[s[i]] < My_dict[s[i + 1]])
            {
                o = -1;
            }
            else
            {
                o = 1;
            }
            t += o * My_dict[s[i]];
        }
        return t += My_dict[s[s.Length - 1]];
    }
}

class FoobarProblems
{
    public int Solution1(List<int> x, List<int> y)
    {
        int tempInt1 = 0;
        x.Sort();
        y.Sort();
        if (x.Count > y.Count)
        {
            for (int i = 0; i < x.Count; i++)
            {
                if (i == x.Count - 1)
                {
                    tempInt1 = x[i];
                    break;
                }
                if (x[i] != y[i])
                {
                    tempInt1 = x[i];
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < y.Count; i++)
            {
                if (y[i] != x[i])
                {
                    tempInt1 = y[i];
                    break;
                }
            }
        }
        return tempInt1;
    }

    public int Solution2(int x, int y)
    {
        int theNumberAtIndexX = 1;
        int startAt2 = 2;
        int[] array1 = new int[x];
        int[] array2 = new int[y];
        for (int i = 0; i < x - 1; i++)
        {
            array1[i] = array1[i] + theNumberAtIndexX;
            theNumberAtIndexX = array1[i] + startAt2;
            startAt2++;
        }
        int temp = 0;
        int startAt0 = 0;
        int addWithPlus1 = 0;
        for (int i = 0; i < y; i++)
        {
            array2[i] = theNumberAtIndexX + addWithPlus1;
            temp = array2[i];
            theNumberAtIndexX = temp;
            addWithPlus1 = x + startAt0;
            startAt0++;
        }
        return temp;
    }

    public int Solution3(int src, int dest)
    {
        return 0;
    }

    public int Solution4(int m, int f)
    {
        return 0;
    }
}

class JumpGame
{
    public bool CanJump(int[] nums)
    {
        int temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > temp)
            {
                return false;
            }
            temp = Math.Max(temp, (i + nums[i]));
        }
        return true;
    }
}

class RobbingHouses
{
    public int RobHouse(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        if (nums.Length == 1)
        {
            return nums[0];
        }
        if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }
        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);
        for (int i = 2; i < dp.Length; i++)
        {
            dp[i] = Math.Max(nums[i] + dp[i - 2], dp[i - 1]);
        }
        return dp[dp.Length - 1];
    }
    //recursion practice
    public int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    
    public float PowerTo(float a, int b)
    {
        if (b == 1)
        {
            return a;
        }
        return a * PowerTo(a, b - 1);
    }

    public int SumTillN(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n + SumTillN(n - 1);
    }

    public int Multiply(int a, int b)
    {
        if (b == 1)
        {
            return a;
        }
        return a + Multiply(a, b - 1);
    }

    public float PowerToNegativeInt(float a, int b)
    {
        if (b == -1)
        {
            return a;
        }
        return (1/a) * PowerToNegativeInt((1/a), b + 1);
    }
}

class Power
{
    public bool IsPowerOfTwo(int n)
    {
        if (n == 0) return false;
        while (n % 2 == 0 && n != 1)
        {
            n /= 2;
        }
        return n == 1 ? true : false;
    }
    public bool IsPowerOfThree(int n)
    {
        if (n == 0 || n == 1) return false;
        if (n % 3 == 0 && n != 1)
        {
            n /= 3;
            return IsPowerOfThree(n);
        }
        else if (n == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsHappy(int n)
    {
        int sum = 0;
        int hasRunSoManyTimes = 100;
        while (sum != 1)
        {
            int length = n.ToString().Length;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = n % 10;
                n /= 10;
            }
            sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += array[i] * array[i];
            }
            n = sum;
            hasRunSoManyTimes--;
            if (hasRunSoManyTimes == 0)
            {
                return false;
            }
        }
        return true;
    }
    public int AddDigits(int num)
    {
        int sum = 0;
        int times = 0;
        if (num == 0) return 0;
        if (num.ToString().Length == 1) return 1;
        while (num.ToString().Length != 1)
        {
            int length = num.ToString().Length;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = num % 10;
                num /= 10;
            }
            sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += array[i];
            }
            num = sum;
            times++;
        }
        return times;
    }
}

class MoveZeroesProblem
{
    public int[] MoveZeroes(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                int[] changeNums = new int[nums.Length + 1];
                changeNums[i + 1] = nums[i];
                
                nums[nums.Length - 1] = 0;
            }
        }
        return new int[] { -1 };
    }
}

class IsSubsequenceProblem
{
    public bool IsSubsequence(string s, string t)
    {
        int jStayTheSame = 0;
        if (s.Length > t.Length) return false;
        if (s.Length == t.Length) return s == t ? true : false;
        for (int i = 0; i < s.Length;)
        {
            for (int j = jStayTheSame; j < t.Length; j++)
            {
                if (s[i] == t[j])
                {
                    if (i != s.Length - 1 && j == t.Length - 1)
                    {
                        return false;
                    }
                    i++;
                    jStayTheSame = j + 1;
                    break;
                }
                if (s[i] != t[j])
                {
                    if (j == t.Length - 1)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}