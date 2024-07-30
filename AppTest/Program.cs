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
            //Дима красавчек ваще
                float CacheResult;
            Console.WriteLine("Введите пример для решения.");
            string Example = Console.ReadLine();
            
            bool MathMultipleDivine = false,MathOther = false ;
            while (MathMultipleDivine == false && MathOther == false)
            {
                string[] Cache = Example.Split(' ');
                int i = 0;
                foreach (var sub in Cache)
                {
                    i++;
                    Console.WriteLine($"Элемент {i}: {sub}");
                }

                for (i = 0; i < Cache.Length; i++)
                {
                    if (Cache[i] == "/" || Cache[i] == "*")
                    {
                        if (Cache[i] == "/")
                        {
                            CacheResult = Convert.ToSingle(Cache[i - 1]) / Convert.ToSingle(Cache[i + 1]);
                            Cache[i] = Convert.ToString(CacheResult);
                            Cache[i - 1] = null;
                            Cache[i + 1] = null;
                            break;
                        }
                        else
                        {
                            CacheResult = Convert.ToSingle(Cache[i - 1]) * Convert.ToSingle(Cache[i + 1]);
                            Cache[i] = Convert.ToString(CacheResult);
                            Cache[i - 1] = null;
                            Cache[i + 1] = null;
                            break;
                        }                       
                    }                 
                }            
                Example = string.Empty;
                int j = 0;
                for (i = 0; i < Cache.Length; i++)
                {
                    if (Cache[i] != null)
                        Example = Example + Cache[i] +" ";
                }
                Array.Clear(Cache, 0, Cache.Length);
                Console.WriteLine($"Новый пример: {Example}");
                Console.WriteLine();
                i = 0;
                Cache = Example.Split(' ');
                foreach (var sub in Cache)
                {
                    i++;
                    Console.WriteLine($"Элемент {i}: {sub}");
                }
                Console.ReadKey();
            }
        }

            

           
        }
    }

