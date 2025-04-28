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
*/

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