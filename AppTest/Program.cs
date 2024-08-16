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
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
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


            //string n = Convert.ToString(ne);
            //int startIndex = 0;
            //int endIndex = 0;
            //int maxNumber = 0;
            //string cacheTail = "";
            //string orderedTail = "";
            //long[] word = new long[n.Length];
            //bool stopCheck = false;
            //for (int i = n.Length - 1; i > 0; i--)
            //{
            //    for (int j = n.Length - 1; j > 0; j--)
            //        if (n[i] < n[j])
            //        {
            //            startIndex = i;
            //            endIndex = j;
            //            stopCheck = true;
            //            break;
            //        }
            //    if (stopCheck == true)
            //        break;
            //}
            //if (stopCheck == false)
            //    return (-1);
            //for (int i = n.Length - endIndex + 1; i < n.Length - 1; i++)
            //{
            //    cacheTail += Convert.ToString(n[endIndex]);
            //    cacheTail += Convert.ToString(n[i]);
            //}
            //cacheTail += Convert.ToChar(n[startIndex]);
            //orderedTail += cacheTail[0];
            //for (int i = 1; i < cacheTail.Length; i++)
            //{
            //    for (int j = 2; j < cacheTail.Length; j++)
            //    {
            //        if (Convert.ToInt64(cacheTail[i]) >= Convert.ToInt64(cacheTail[j]))
            //            maxNumber = Convert.ToInt32(cacheTail[i]);
            //    }
            //    orderedTail += maxNumber;
            //}
            //maxNumber = 0;
            //for (int i = 0; i < orderedTail.Length; i++)
            //    word[i] = Convert.ToInt64(orderedTail[i]);

            //for (int i = 0; i < word.Length; i++)
            //    for (int j = 0; j < word.Length - 1; j++)
            //        if (Convert.ToInt64(word[j]) < Convert.ToInt64(word[j + 1]))
            //        {
            //            maxNumber = Convert.ToInt32(word[j + 1]);
            //            word[j + 1] = word[j];
            //            word[j] = maxNumber;
            //        }
            //cacheTail = string.Empty;

            //for (int i = 0; i > n[endIndex - 1]; i++)
            //    cacheTail += Convert.ToString(n[i]);

            //for (int i = 0; i < word.Length; i++)
            //    cacheTail += word[i];

            //return Convert.ToInt64(cacheTail);


            int[] arr = { 20, 19, 25, 16, 19, 30, 18, 24 };
            int temp = 0;
            int centre = 0;
            int countr = 1;
            int countl = 1;
            int[] answer = new int[arr.Length];
            for (int write = 0; write < arr.Length; write++)            
                for (int sort = 0; sort < arr.Length - 1; sort++)                
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();


            centre = (arr.Length - 1) / 2;
            answer[centre] = arr[0];

            for (int i = 1 ; i < arr.Length;i++)
                if (i % 2 == 0)
                {
                    answer[centre - countr] = arr[i];
                    countr++;
                }
                else
                {
                    answer[centre + countl] = arr[i];
                    countl++;
                }
            

            


            for (int i = 0; i < answer.Length; i++)
                Console.Write(answer[i] + " ");
            Console.ReadKey();















            Console.ReadLine();




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