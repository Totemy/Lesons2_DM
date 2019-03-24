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
                Console.WriteLine($"Input name {i} person");
                a[i].name = Console.ReadLine();
                Console.WriteLine($"Input surname {i} person");
                a[i].surname = Console.ReadLine();
                Console.WriteLine($"Input phone number {i} person");
                a[i].phoneNumber = Console.ReadLine();
                /* Console.WriteLine($"Input day {i} person");
                 a[i].date[0] = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine($"Input mounth {i} person");
                 a[i].date[1] = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine($"Input year {i} person");
                 a[i].date[2] = Convert.ToInt32(Console.ReadLine());
                 */


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
                StreamReader f = new StreamReader("text.txt");
                string s = f.ReadLine();
                Console.WriteLine(s);
                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Surname not found: " + e.Message);
                Console.WriteLine("Перевірте правильність прізвища!");
                return;
            }
           
        }
        static void Main(string[] args)
        {
            Console.Write("Input person number : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Person[] array = new Person[value];


            WriteInfo(array);
            WriteInFile(array);
            PrintInfo(array);
            Console.ReadKey();
        }
    }
}
