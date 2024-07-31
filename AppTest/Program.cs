#define Calc
//#define Test

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if Calc
            float CacheResult;
            int CountMathIterations = 0, i, DoPlusMinus=0;

            Console.WriteLine("Введите пример для решения.");
            string Example = Console.ReadLine();

            for (i = 0; i < Example.Length; i++)
            {
                if (Example[i] == '/' || Example[i] == '*' || Example[i] == '+' || Example[i] == '-')
                    CountMathIterations++;
            }

            while (CountMathIterations > 0)
            {
                string[] Cache = Example.Split(' ');

                //i = 0;
                //foreach (var sub in Cache)
                //{
                //    i++;
                //    Console.WriteLine($"Элемент {i}: {sub}");
                //}

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
                {
                    if (Cache[i] != null)
                        Example = Example + Cache[i] + " ";
                }

                //Console.WriteLine($"Новый пример: {Example}");
                //Console.WriteLine();
            }
            Console.WriteLine($"Ответ: {Example}");
            Console.ReadKey();
#endif



#if Test
            




#endif 
        }




    }
}

