using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Calculator
{
    class Program{
        static void Main(string[] args){
            int number1;
            int number2;

            string ans;
            int result;

            bool validOperation = true;

            Console.WriteLine("Welcome to the calculator program!");

            Console.WriteLine("Please enter your first number : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("What operation do you want to use ?");
            ans = Console.ReadLine();
            

            Console.WriteLine("Please enter your second number : ");
            number2 = Convert.ToInt32(Console.ReadLine());


            if(ans == "+"){
                result = number1+number2;
            }
            else if(ans == "-"){
                result = number1-number2;
            }
            else if(ans == "*"){
                result = number1*number2;
            }
            else if (ans == "/"){
                if (number2 == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                            validOperation = false;
                            return;
                        }
                        else
                        {
                            result = number1 / number2;
                        }
            }
            else{
                 Console.WriteLine("wrong input!!");
                 validOperation = false;
                 return;
            }
            
            if(validOperation){
            Console.WriteLine(result);
            }
        }
    }
}
