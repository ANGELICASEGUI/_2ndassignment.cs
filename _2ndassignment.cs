using System;
namespace _2ndassignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            for (int Num = 1; Num <=100; Num++)
            {
                
                if (Num % 3 == 0)
                {
                    Console.WriteLine("HELLO");
                }
                else if (Num % 5 == 0)
                {
                    Console.WriteLine("GOODBYE");
                }
                else if (Num % 15 == 0)
                {
                    Console.WriteLine("HELLO GOODBYE");
                }
                else
                {
                    Console.WriteLine(Num);
                }

                
            
                   



            }


        }
    }
}
