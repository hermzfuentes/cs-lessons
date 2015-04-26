using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string ln;
            string fn;

            string myInput;

            int a = 0;
            

        start:
            {
                Console.WriteLine("Please enter your name:");
                fn = Console.ReadLine();
                Console.WriteLine("Please enter your Lastname:");
                ln = Console.ReadLine();

                Console.Write("Type \"YES\" to go on or \"NO\" to stop:");
                myInput = Console.ReadLine();
                {
                    switch (myInput)
                    {
                        case "yes":
                            goto start;
                        case "no":
                            break;
                    }
                } while (a < 0) ;

                string[,] arr = new string[2, 5];

                

                for (int y = 0; y < arr.GetLength(0); y++) 
                {
                    for (int x = 0; x < arr.GetLength(1); x++) 
                    {
                        
                        //Console.Write("" + arr[y, x]);
                        //Console.WriteLine(fn + " " + ln);
                        Console.WriteLine("{0}",fn + ln);
                        myInput = Console.ReadLine();
                    }
                }
                  

               
            }
        }
    }
}
