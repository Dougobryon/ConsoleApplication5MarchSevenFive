using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5MarchSevenFive
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number Here");
            int n = int.Parse(Console.ReadLine());
            int startingNum = n;

            decimal factorial = 1;
            do
            
            
           
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;

            }
            while (true) ;

                Console.WriteLine(startingNum + "! = " + factorial);


        }
    }
}
