using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2
{
    class Program
    {
        struct Person
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string phoneNumber { get; set; }
            public int[] date { get; set; }
        }
        static void WriteInfo(Person[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Input name {i+1} person");
                a[i].name = Console.ReadLine();
                Console.WriteLine($"Input surname {i+1} person");
                a[i].surname = Console.ReadLine();
                Console.WriteLine($"Input phone number {i+1} person");
                a[i].phoneNumber = Console.ReadLine();
            }
        }

        static void WriteInFile(Person[] a)
        {
            try
            {
                StreamWriter f = new StreamWriter("text.txt");
                for (int i = 0; i < a.Length; i++)
                {
                    f.WriteLine(a[i].name);
                    f.WriteLine(a[i].surname);
                    f.WriteLine(a[i].phoneNumber);
                    f.WriteLine(" -- ");
                }


                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return;
            }

        }
         static void PrintInfo(Person[] a)
         {
             try
             {
                /*StreamReader f = new StreamReader("text.txt");
                string s = f.ReadToEnd();
                Console.WriteLine(s);
                f.Close();*/
                string[] NewFile = File.ReadAllLines("text.txt");
                foreach (string str in NewFile)
                {
                    Console.WriteLine(str);
                }
                
                Console.ReadKey(true);
            }
             catch (Exception e)
             {
                 Console.WriteLine("file not found: " + e.Message);
                 
                 return;
             }


         }
        static void Main(string[] args)
        {
            Console.Write("Input person number : ");
            int value = Convert.ToInt32(Console.ReadLine());

            Person[] array = new Person[value];
        

            int menuItem;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Виберіть дію:");
                Console.WriteLine();
                Console.WriteLine(" [1] - введення даних з клавіатури");
                Console.WriteLine(" [2] - вивід даних на екран");
                Console.WriteLine();
                Console.WriteLine(" [0] - вихід та завершення роботи програми");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Введіть значення: ");
                menuItem = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
               

                switch (menuItem)
                {
                    case 1:
                        
                        WriteInfo(array);
                        WriteInFile(array);

                        break;
                    case 2:
                        PrintInfo(array);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ви ввели помилкове значення! " +
                        "Слід ввести число - номер вибраного пункту меню");
                        break;
                }
            } while (menuItem != 0);
        }

    }
}

