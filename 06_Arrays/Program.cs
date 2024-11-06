using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri


            //string[] Color = new string[4];
            //Color[0] = "sarı";
            //Color[1] = "kırmızı";
            //Color[2] = " mavi";
            //Color[3] = "lacivert";

            //Console.WriteLine(Color[2]);

            //String[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "ankara";
            //cities[2] = "barcelona";
            //cities[3] = "newyork";
            //cities[4] = "kahire";

            //Console.WriteLine(cities[4]);


            //int[] number = new int[10];

            //number[0] = 4;
            //number[1] = 5;
            //number[2] = 6;
            //number[7] = 7;
            //Console.WriteLine(number[5]);


            //string[] cities = { "prag " ,"roma ","ankara", "giresun"};
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] color = { "Sarı", "Kırmızı", "Mavi", "Mor" ,"Lacivert"};

            //for (int i = 0; i < color.Length; i++)
            //{
            //    Console.WriteLine(color[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 52, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-', };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = {47,85,95,41,25,35,789,86,100 };
            //int maxNumber = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);


            //string[] person = { "ali", "ahmet", "ayşe", "buse","cem","deniz","derya" };
            //Console.WriteLine(person.Length);


            //int[] numbers = { 45,85,52,41,86,10,22,35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "buse ", "ayşegül", "merve", "çınar", "kaya", "derya" };
            //int index = Array.IndexOf(customers, "derya");
            //Console.WriteLine(index);

            //int[] numbers = { 45,85,96,63,74,10,25,22,36 };
            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max() + " dizinin en küçük elemanı : " + numbers.Min());

            #endregion

            #region Kullanıcadan Değer alma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"lütfen {i + 1}. şehri giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //foreach (string s in cities)
            //{
            //    Console.WriteLine(s);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            Console.WriteLine("Çift sayilar");
            Console.WriteLine();
            int[] numbers = { 21, 42, 33, 54, 55, 66, 748, 897, 39, 220 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {

                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Tek sayilar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {

                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion
            Console.Read();
        }
    }
}