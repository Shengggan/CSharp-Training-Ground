using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name: ");
            string inputString = Console.ReadLine();
            try { 
                if(inputString.Length > 20) {
                    throw new Exception ("Input name should not be greater than 20 characters");
                }
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                try {
                    if(age > 150) {
                        throw new Exception("Input age can not be above 150");
                    }
                    Console.WriteLine("Hello " + inputString + " your age is " + age);
                    return;
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }


        }
    }
}
