using System;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of even numbers");


            /*int[] evenNums = new int[6];
            int sum = 0;

            Console.WriteLine("Enter the first number");
            evenNums[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            evenNums[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            evenNums[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number");
            evenNums[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fifth number");
            evenNums[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the sixth number");
            evenNums[5] = int.Parse(Console.ReadLine());



            for (int i = 0; i < evenNums.Length; i++)
            {
                if (i % 2 == 0)
                    sum += evenNums[i];
                else
                    Console.WriteLine("You number is not even");
            }
            */


            int size;
            int oddSum = 0, evenSum = 0;

            Console.WriteLine("Enter the size of the array:");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter the array values:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenSum += arr[i];
                }
                else
                {
                    oddSum += arr[i];
                }
            }
            Console.WriteLine("Even Sum: " + evenSum + " Odd Sum: " + oddSum);




            Console.ReadLine();
        }
    }
}
