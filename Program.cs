namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSum = MaxSubarray(nums);
            Console.WriteLine(maxSum);

            int a = 9;
            int b = 6;
            Console.WriteLine(Gcd(a, b));

            Console.WriteLine(GetFirstElement(nums));
        }

        // Kadane's algorithm O(n)
        // https://leetcode.com/problems/maximum-subarray
        static int MaxSubarray(int[] nums)
        {
            int localMax = 0;
            int globalMax = int.MinValue;

            foreach (int num in nums)
            {
                localMax = Math.Max(num, localMax + num);
                globalMax = Math.Max(localMax, globalMax);
            }

            return globalMax;
        }

        // Euclid’s Algorithm O(log n)?
        static int Gcd(int a, int  b)
        {
            if (b == 0) return a;
            return Gcd(b, a % b);

        }

        // simple stupid O(1)
        static int GetFirstElement(int[] data)
        {
            return data[0];
        }
    }
}
