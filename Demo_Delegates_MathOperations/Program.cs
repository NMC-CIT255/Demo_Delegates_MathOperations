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
            NONE, // dummy value of -9999 set
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

            Console.Write("Choose an operation: ");
            operationChoice = (Operation)Enum.Parse(typeof(Operation), Console.ReadLine().ToString().ToUpper());

            switch (operationChoice)
            {
                case Operation.ADD:
                    myMathOperation = Add;
                    break;
                case Operation.SUBTRACT:
                    myMathOperation = Subtract;
                    break;
                case Operation.MULTIPLY:
                    myMathOperation = Multiply;
                    break;
                case Operation.DIVIDE:
                    myMathOperation = Divide;
                    break;
                case Operation.POWER:
                    myMathOperation = Power;
                    break;
                default:
                    myMathOperation = None;
                    break;
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
