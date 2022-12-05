// See https://aka.ms/new-console-template for more information
using System.Reflection.Emit;
static void getInput(string label1, string label2, out double input1, out double input2)
{
    // get values from user
    Console.WriteLine("Input the " + label1 + " value: ");
    string input1Str = Console.ReadLine();
    input1 = Convert.ToDouble(input1Str);

    Console.WriteLine("Input the " + label2 + " value: ");
    string input2Str = Console.ReadLine();
    input2 = Convert.ToDouble(input2Str);
 
}


static double calculate()
{
    double answer = 0;
    double input1 = 0;
    double input2 = 0;

    Console.WriteLine("Enter the number corresponding to the calculation you wish to perform: \n1. Volume of Cube\n2. Area of rectangle\n3. Area of triangle\n4. Area of circle\n5. Volume of sphere\n6. Volume of cone\n7. Volume of cylinder ");
    string calcTypeInput = Console.ReadLine();

    if (calcTypeInput == "1")
        // cube
    {
        getInput("cube base", "cube height", out input1, out input2);
        answer = input1 * input2;
        return answer;

    }
    else if (calcTypeInput == "2")
        // rectangle
    {
        getInput("rectangle base", "rectangle height", out input1, out input2);
        answer = input1 * input2;
        return answer;
    }
    else if (calcTypeInput == "3")
        // triangle
    {
        getInput("triangle base", "triangle height", out input1, out input2);
        answer = (input1 * input2)/2;
        return answer;
    }
    else if (calcTypeInput == "4")
        // circle
    {
        getInput("circle radius", "n/a", out input1, out input2);
        answer = (input1 * input1)* Math.PI;
        return answer;

    }
    else if (calcTypeInput == "5")
        // sphere
    {
        getInput("sphere radius", "n/a", out input1, out input2);
        answer = (4/3) * Math.PI * Math.Pow(input1, 3) ;
        return answer;
    }
    else if (calcTypeInput == "6")
        // cone
    {
        getInput("cone height", "cone radius", out input1, out input2);
        answer = Math.PI * Math.Pow(input2,2) * (input1/3);
        return answer;
    }
    else if (calcTypeInput == "7")
        // cylinder
    {
        getInput("cylinder radius", "cylinder height", out input1, out input2);
        answer = Math.PI * Math.Pow(input1,2) * input2;
        return answer;
    }
    else
    {
        return -99999;
    }
}

double calcResult = calculate();

Console.WriteLine(calcResult);