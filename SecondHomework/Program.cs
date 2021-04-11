using System;

namespace SecondHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Hello Student Group");


            string[] studentsG1 = new string[] { "Jordan", "Nowitzki", "AbdulJabar", "Zubizareta", "Sampras" };


            string[] studentsG2 = new string[] { "Maradona", "Pele", "Garbajosa", "Tupac", "Biggie" };



            Console.WriteLine("Enter 1 or 2: ");
            int input = int.Parse(Console.ReadLine());


            /*
            if (input == 1)
            {


                Console.WriteLine(" \n Second group");
                foreach (string item in studentsG1)
                

                    Console.WriteLine(item);
                        

            }
           

            else if (input == 2)
            {

                Console.WriteLine(" \n Second group");
                foreach (string item in studentsG2)
                
                    Console.WriteLine(item);
              
            }

            else
                Console.WriteLine("You entered a wrong number! ");

            */

            switch (input)
            {
                case 1:
                    if (input == 1)
                    {
                        Console.WriteLine(" \n First group: ");
                        foreach (string item in studentsG1)


                            Console.WriteLine(item);
                    }

                    break;
                case 2:
                    if (input == 2)
                    {
                        Console.WriteLine(" \n Second group: ");
                        foreach (string item in studentsG2)

                            Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("You entered a wrong number!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
