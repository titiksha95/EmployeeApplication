using System;

namespace EmployeeManagementSystem.Utilities
{
    public class Validation
    {
        public static int ReadInt(string message)
        {
            int value;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid Input.");
            }
        }

        public static double ReadDouble(string message)
        {
            double value;

            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Invalid Input.");
            }
        }
    }
}