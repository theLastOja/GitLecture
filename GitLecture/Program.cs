﻿using System;

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
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
