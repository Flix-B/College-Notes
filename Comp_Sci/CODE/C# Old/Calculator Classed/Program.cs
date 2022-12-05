// See https://aka.ms/new-console-template for more information
using Calculator_Classed;
using System.Reflection.Emit;



internal class Program
{
    private static void Main(string[] args)
    {
        

    // Instantiate an instance of my class "Calculator"
        Calculator calcObj = new Calculator();  // Create an object of Calculator class type



     // Set class property "calcType" ready to call method "calculateResult"
        Console.WriteLine("Enter the number corresponding to the calculation you wish to perform: \n1. Volume of Cube\n2. Area of rectangle\n3. Area of triangle\n4. Area of circle\n5. Volume of sphere\n6. Volume of cone\n7. Volume of cylinder ");
        calcObj.calcTypeInput = Console.ReadLine();


        // Compute result by calling class method "calculate"
        

        Console.WriteLine("The answer to your calculation is: "+calcObj.calculateResult());
    }
}

