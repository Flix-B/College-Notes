using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Calculator_Classed
{
    class Calculator
    {

        public double input1;  // property
        public double input2;  // property
        public string calcTypeInput;  //property

        public Calculator()  // Class constructor
        {
            // set all properties to 0
            //input1 = 0;
            //input2 = 0;
           
        }



        static void getInput(string label1, string label2, out double inp1, out double inp2)
        {

            // get values from user
            Console.WriteLine("Input the " + label1 + " value: ");
            string input1Str = Console.ReadLine();
            inp1 = Convert.ToDouble(input1Str);

            if (label2 == "n/a")
            {
                inp2 = 0;
            }
            else
            { 
                Console.WriteLine("Input the " + label2 + " value: ");
                string input2Str = Console.ReadLine();
                inp2 = Convert.ToDouble(input2Str);
            }
        }

        public double calculateResult()  // Method
        { 
            double answer = 0;
            double inp1 = 0;
            double inp2 = 0;
           

            if (calcTypeInput == "1" || calcTypeInput == "2")
            // cube + rectangle
            {
                getInput("base", "height", out inp1 , out inp2);
                answer = inp1 * inp2;
            }
            else if (calcTypeInput == "2")
            // rectangle
            {
                getInput("rectangle base", "rectangle height", out inp1,out inp2);
                answer = inp1 * inp2;
            }
            else if (calcTypeInput == "3")
            // triangle
            {
                getInput("triangle base", "triangle height", out inp1, out inp2);
                answer = (inp1 * inp2) / 2;
            }
            else if (calcTypeInput == "4")
            // circle
            {
                getInput("circle radius", "n/a", out inp1, out inp2);
                answer = (inp1 * inp1) * Math.PI;
         
            }
            else if (calcTypeInput == "5")
            // sphere
            {
                getInput("sphere radius", "n/a", out inp1, out inp2);
                answer = (4 / 3) * Math.PI * Math.Pow(inp1, 3);
            }
            else if (calcTypeInput == "6")
            // cone
            {
                getInput("cone height", "cone radius", out inp1, out inp2);
                answer = Math.PI * Math.Pow(inp2, 2) * (inp1 / 3);
            }
            else if (calcTypeInput == "7")
            // cylinder
            {
                getInput("cylinder radius", "cylinder height", out inp1, out inp2);
                answer = Math.PI * Math.Pow(inp1, 2) * inp2;
            }
            else
            {
                Console.WriteLine("Wrong value entered!");
                return -99999;
            }

            //Set external propery input1 and 2 so that they can be viewed externally if required
            input1 = inp1;
            input1 = inp2;
            
            //Return the calculated result
            return answer;


        }

    }

    
}
