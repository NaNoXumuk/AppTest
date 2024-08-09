//#define Calculator
//#define ArrayChecker
//#define FacebookLiker
//#define Origami
//#define HighandLow
//#define Test
//#define CheckNumber
#define CheckPassword

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppTest
{

internal class Program
{
        static void Main(string[] args)
    {
#if Calculator
            float CacheResult;
            int CountMathIterations = 0, i, DoPlusMinus = 0;

            Console.WriteLine("Введите пример для решения.");
            string Example = Console.ReadLine();

            for (i = 0; i < Example.Length; i++)
                if (Example[i] == '/' || Example[i] == '*' || Example[i] == '+' || Example[i] == '-')
                    CountMathIterations++;

            while (CountMathIterations > 0)
            {
                string[] Cache = Example.Split(' ');
                for (i = -1; i <= Cache.Length - 1;)

                {
                    i = i + 2;
                    if (i >= Cache.Length)
                    {
                        DoPlusMinus = 1;
                        i = 1;
                    }
                    if ((Cache[i] != "+" && Cache[i] != "-") || (DoPlusMinus != 1))
                        switch (Cache[i])
                        {
                            case "/":
                            case "*":
                                if (Cache[i] == "/")
                                    CacheResult = Convert.ToSingle(Cache[i - 1]) / Convert.ToSingle(Cache[i + 1]);
                                else
                                    CacheResult = Convert.ToSingle(Cache[i - 1]) * Convert.ToSingle(Cache[i + 1]);
                                Cache[i] = Convert.ToString(CacheResult);
                                Cache[i - 1] = null;
                                Cache[i + 1] = null;
                                i = Cache.Length;
                                break;
                        }
                    else
                        switch (Cache[i])
                        {
                            case "+":
                            case "-":
                                if (Cache[i] == "+")
                                    CacheResult = Convert.ToSingle(Cache[i - 1]) + Convert.ToSingle(Cache[i + 1]);
                                else
                                    CacheResult = Convert.ToSingle(Cache[i - 1]) - Convert.ToSingle(Cache[i + 1]);
                                Cache[i] = Convert.ToString(CacheResult);
                                Cache[i - 1] = null;
                                Cache[i + 1] = null;
                                i = Cache.Length;
                                break;
                        }
                }
                CountMathIterations--;
                Example = string.Empty;

                for (i = 0; i < Cache.Length; i++)
                    if (Cache[i] != null)
                        Example = Example + Cache[i] + " ";
            }
            Console.WriteLine($"Ответ: {Example}");
            Console.ReadKey();
        
#endif


#if FacebookLiker
            try
            {
                int i = name.Length;
                switch (Convert.ToString(i))
                {
                    case "1":
                        return $"{name[0]} likes this";
                    case "2":
                        return $"{name[0]} and {name[1]} like this";
                    case "3":
                        return $"{name[0]}, {name[1]} and {name[2]} like this";
                    default:
                        return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
                }
                throw new Exception("error");
            }
            catch (Exception)
            {
                return "no one likes this";
            }
#endif

#if Origami
            int a = 10;
            int b = 7;
            int sum = 0;
            while (a > 0 && b > 0)
            {
                if (a > b)
                {
                    a -= b;
                    sum++;
                }
                else
                {
                    b -= a;
                    sum++;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
#endif

#if HighandLow
            string Numbers = "1 2 3 4 5 6 7 8";
            int low = int.MaxValue;
            int high = int.MinValue;
          string[]  Cache= Numbers.Split(' ');
            Numbers = null;
            for (int i = 0; i < Cache.Length; i++)
            {
             if (Convert.ToInt32(Cache[i]) < low)
                low = Convert.ToInt32(Cache[i]);
             if (Convert.ToInt32(Cache[i]) > high)
                    high = Convert.ToInt32(Cache[i]);
            }
            Numbers = high + " " + low;
            Console.WriteLine(Numbers);
            Console.ReadKey();
#endif

#if Test
            int count = 0;
            int rule=0;
            List<int> list = new List<int>();
            list.AddRange(new[] { 270, 810,1080, 1350, 1620 });
            //list.AddRange(new[] { 1620,1080, 810, 540, 270 });
            Console.WriteLine(list.Last());
            for (int i = 0; i < list.Count; i++)
                if (list[i] - list[i + 1] == list[i + 1] - list[i + 2])
                {
                    rule = list[i+1] - list[i];
                    break;
                }
            Console.WriteLine(rule);
            Console.WriteLine($"{list[0]}  {list[1]}");
            for (int i = 0; i < list.Count;)
            {
                if (list[i] + rule != list[i + 1])
                {
                    count = i;
                    break;
                }
                i++;
            }
            Console.WriteLine( list[count] + rule);

            Console.ReadKey();
#endif

#if CheckNumber
            string s = "streSS";
            s=s.ToUpper();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        count++;
                }
                if (count == 1)
                {
                    Console.WriteLine(s[i]);
                    Console.ReadKey();
                    break;
                }
                count = 0;
            }
#endif

#if CheckPassword
            string str = "he_llo";
            string Check = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < str.Length; i++)
                if (!Check.Contains(str[i]))
                    Console.WriteLine("true");
            else
                    Console.WriteLine(str[i]);
            Console.ReadKey();
#endif











        }
#if ArrayChecker
        static void ArrayChecker(string[] args)
        {
            int[] arr1 = new[]
          {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
            28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53,
            54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79,
            80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99
        }; // 100
            
            Console.WriteLine(MissingNo(arr1));
            Console.ReadKey();
        }
        public static int MissingNo(int[] nums)
        {
            int Count = 0, Missnumber = 0;
            bool flag = false;
            for (int i = 0; i < nums.Length + 1; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (Count == nums[j])
                        flag = true;
                }
                if (flag == true)
                {
                    Count++;
                    flag = false;
                }
                else
                    Missnumber = Count;
            }            
            return Missnumber;

        }
#endif
}
}