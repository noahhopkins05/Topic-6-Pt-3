using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

namespace Topic_6_Pt_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int number;
            int oddSum = 1;
            int i = 0;
            string input;

            Console.WriteLine("Type any text to exit.");
            Console.WriteLine("Enter a number");
            input = Console.ReadLine();

            while (i == 0)
            { 

                if (Int32.TryParse(input, out number))
                {
                    if (oddSum > number)
                    {
                        Console.WriteLine("The total of the numbers is " + total);
                        Console.WriteLine("Thank you for using OddSum");
                        i = 1;
                    }
                    else 
                    {
                        total = oddSum + total;
                        oddSum = oddSum + 2;
                    }
                }
                else
                {
                    i = 1;
                    Console.WriteLine("Thank you for using OddSum");
                }
            }
        }
    }
}