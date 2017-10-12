using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegates_MathOperations
{
    class Program
    {
        public delegate double MathOperation(double number1, double number2);

        public enum Operation
        {
            NONE,
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE,
            POWER
        }

        static void Main(string[] args)
        {
            MathOperation myMathOperation;
            Operation operationChoice;

            double myNumber1;
            double myNumber2;

            Dictionary<Operation, MathOperation> operationsDictionary = new Dictionary<Operation, MathOperation> 
            {
                {Operation.ADD, Add},
                {Operation.SUBTRACT, Subtract},
                {Operation.MULTIPLY, Multiply},
                {Operation.DIVIDE, Divide}
            };

            //operationsDictionary.Add(Operation.POWER, Power);
            //operationsDictionary.Remove(Operation.ADD);

            Console.Write("Choose an operation: ");
            operationChoice = (Operation)Enum.Parse(typeof(Operation), Console.ReadLine().ToString().ToUpper());

            if (operationsDictionary.ContainsKey(operationChoice))
            {
                myMathOperation = operationsDictionary[operationChoice];
            }
            else
            {
                myMathOperation = None;
            }

            Console.Write("Enter the first number: ");
            myNumber1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            myNumber2 = double.Parse(Console.ReadLine());

            Console.WriteLine("The answer is: {0}", myMathOperation(myNumber1, myNumber2));

            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }

        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
        public static double Power(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }

        public static double None(double number1, double number2)
        {
            return -9999;
        }
    }
}
