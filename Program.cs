using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater {
    class Program {
        static void Main(string[] args) {
            int num1;
            int num2;
            int result;
            string answer;
            Console.WriteLine("Hello, welcome to the calculator program");
            Console.WriteLine("Press enter your First number.");
            num1 = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Press enter your Second number.");
            num2 = Convert.ToInt32(Console.ReadLine()) ;
            System.Console.WriteLine("what type operation would you like to perform?");
            System.Console.WriteLine("Please enter a for addition,s for subtraction, m for multiplication, and other key for division");
            answer = Console.ReadLine();
            if(answer == "a"){
               result = num1+num2;
            }else if(answer == "s"){
               result = num1-num2;
            }else if(answer=="m"){
                result = num1*num2;
            }else {
                result = num1/num2;
            }
            System.Console.WriteLine("the result is: " + result);
            System.Console.WriteLine("Thank you for using our Calculator program");
            Console.ReadKey();
        }
    }
}
