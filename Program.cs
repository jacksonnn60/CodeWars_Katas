using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace sortingByInsert
{
    class Program
    {

        static void Main(string[] args)
        {
            
        }
        public static int Factorial(int n)
        {
            if (n < 0 || n >= 12)
                throw new ArgumentOutOfRangeException();
            else if (n == 0)
                return 1;
            else
            {
                int f = 1;
                for (int i = 1; i <= n; i++)
                { f *= i; }
                return f;
            }
            
        }
        public static int[] minMax(int[] lst)
        {
            int[] maxMin = { lst.Min(), lst.Max() };
            return maxMin;
        }
        public static long FindNextSquare(long num)
        {
            if (Math.Sqrt(num) % 1 == 0)
                return (long)Math.Pow(Math.Sqrt(num) + 1, 2);
            else
                return -1;
        }
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int[] n = numbers.ToArray();
            for (int i = 0; i < n.Length - 2;)
            {
                if (n[i] != n[i + 1] && n[i] != n[i + 2])
                    return n[i];
                else if (n[i] != n[i + 1] && n[i] == n[i + 2])
                    return n[i + 1];
                else if (n[i] == n[i + 1] && n[i] != n[i + 2])
                    return n[i + 2];
                else i++;
            }

            return -1;
        }
        public static int GetBiggest(int[] list)
        {
            Array.Sort(list);
            Array.Reverse(list);
            string s = "";
            for (int i = 0; i <= list.Length - 1; i++)
                s += list[i];
            int res = int.Parse(s);
            return res;
        }
        public static int RoundToNext5(int n)
        {
            while (n % 5 != 0)
            {
                if (n % 5 == 0)
                    return n;
                n++;
            }
            return n;
        }
        public static int[] Capitals(string word)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (char.IsUpper(word[i]))
                    indexes.Add(i);
            }
            int[] array = indexes.ToArray();
            return array;

        }
        public static string Solve(string s)
        {
            int l = 0;
            int u = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (char.IsUpper(s[i]))
                    u++;
                else
                    l++;
            }
            if (u > l)
                return s.ToUpper();
            else
                return s.ToLower();
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] arr = new int[2];
            for (int i = 0; i <= numbers.Length - 1;)
            {
                int k = i + 1;
                while (k <= numbers.Length - 1)
                {
                    if (numbers[i] + numbers[k] == target)
                    {
                        arr[0] = i;
                        arr[1] = k;
                        return arr;
                    }
                    else
                        k++;
                }
                i++;
            }

            return new int [0];
        }
        public static int Stray(int[] numbers)
        {
            Array.Sort(numbers);
            if (numbers[0] == numbers[1])
                return numbers[numbers.Length - 1];
            return numbers[0];
        }
        public static int AdjacentElementsProduct(int[] array)
        {
            List<int> l = new List<int>();
            for (int i = 0; i < array.Length - 1; i++)
            {
                int number = array[i] * array[i + 1];
                l.Add(number);
            }
            l.Sort();
            return l.Max();
        }
        public static int DescendingOrder(int num)
        {
            string s = num.ToString();
            string res = "";
            int[] arr = new int[s.Length];
            for (int i = 0; i <= s.Length - 1; i++)
                arr[i] = int.Parse(s[i].ToString());
            Array.Sort(arr);
            for (int k = arr.Length - 1; k >= 0; k--)
                res += arr[k];
            return int.Parse(res);
        }



            //DOROBYTY++
            public static int FindLongest(int[] number)
        {
            if (number[0].ToString().Length == number.Max().ToString().Length)
                return number[0];
            return number.Max();
        }


    }
}
