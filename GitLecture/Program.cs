using System;

namespace GitLecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int result = Add(num1, num2);
            Console.WriteLine(result);

            result = Multiply(num1, num2);
            Console.WriteLine(result);

            result = Divide(num2, num1);
            Console.WriteLine(result);
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        private static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
