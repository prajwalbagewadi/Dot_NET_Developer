using System;
using static System.Console; //to omit the Console using 
namespace Io{
    class InputOutput{
        static void Main(string[] args){
            //In C#, input and output are typically handled using the Console class from the System namespace.
            //ouput 
            Console.WriteLine("helloworld1");
            //Writes a message and moves to the next line.
            Console.WriteLine("helloworld2");
            //Writes a message without moving to the next line.
            Console.Write("hello.");
            Console.Write("world.");

            //Console omited
            WriteLine("WriteLine without Console.");

            //Input
            WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            WriteLine("Hello. "+name);
            //Reads a line of text entered by the user as a string.
            //If you need numeric input:
            //You must convert the input from string to the desired type
            WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(ReadLine());
            WriteLine("Enter Your Salary:");
            double sal = Convert.ToDouble(ReadLine());
            WriteLine("Age:"+age+" Salary:"+sal);
        }
    }
}