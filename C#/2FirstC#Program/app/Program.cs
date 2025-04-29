/*
**Writing Your First C# Program**
   - Structure of a C# program
   - `Main()` method
   - Compiling and running programs
*/

/*
Writing Your First C# Program

1. Structure of a C# Program

A basic C# program consists of:

Namespaces: Organize code into groups.

Classes: Define the structure and behavior of objects.

Methods: Define actions the program can take.

Statements: The actual code that runs inside methods.

create a new project: dotnet new console -o app //in working dir
*/

/*
using System; //Namespace
namespace HelloWorld //Namespace 
{
   class Program //Class
   {
      static void Main(string[] args) //Main method (entry point)
      {
         Console.WriteLine("helloWorld!"); //Statement
      }
   }
}
*/
using System; //namespace
/*
using is a keyword that tells the compiler you want to include a namespace.

System is a built-in C# namespace that contains important classes,
like Console, which you need to interact with the console 
(for reading input, writing output, etc.).
*/
namespace HelloWorld{ //namespace
/*
A namespace is like a container for classes and other types.
Here, you’re defining your own namespace called HelloWorld. 
It helps organize your code and avoid name conflicts.
*/

    class Program{ //class
    /*
    Inside the namespace, you define a class called Program.
    A class is a blueprint for objects — 
    it groups related methods and data together. 
    In this case, the Program class contains the program’s starting point.
    */

        static void Main(string[] args){//Main method (entry point)
        /*
        Main is the entry point of every C# console application.
        When you run the program, execution starts from the Main method.
        static means you don't need to create an object of Program to run Main.
        string[] args allows the program to receive command-line arguments (even though you don't use them here).
        */

            Console.WriteLine("helloworld! of C#"); //executing statement
            //Console.WriteLine prints text to the console.
        }
    }
}