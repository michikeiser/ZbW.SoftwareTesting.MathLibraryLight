namespace ZbW.Math.TestApp.Library.Console
{
    using System;

    public static class Program
    {
        private const string TEXT_TEST_PASSED = "--> Passed\n";

        private const string TEXT_TEST_FAILED = "--> Failed!!!\n";

        private const string TEXT_IS_CORRECT = " is correct";

        private const string TEXT_IS_WRONG = " is wrong";

        public static void Main(string[] args)
        {
            var basicOperations = new BasicOperation();

            Console.WriteLine("######################################################");
            Console.WriteLine("# Hi, I'm your Test Application for MathLibary Light #");
            Console.WriteLine("######################################################");
            Console.WriteLine();

            // **********************************************************************************************
            // Test Addition
            // **********************************************************************************************
            Console.WriteLine("Try to test Method 'Addition'");
            var additionResult = basicOperations.Addition(2, 3);
            var additionOperation = $"Result: '2 + 3 = {additionResult}'";

            if (additionResult == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{additionOperation}{TEXT_IS_CORRECT}");
                Console.WriteLine(TEXT_TEST_PASSED);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{additionOperation}{TEXT_IS_WRONG}");
                Console.WriteLine(TEXT_TEST_FAILED);
                Console.ResetColor();
            }

            // **********************************************************************************************
            // Test Subtraction
            // **********************************************************************************************
            Console.WriteLine("Try to test Method 'Subtraction'");
            var subtractionResult = basicOperations.Subtraction(20, 5);
            var subtractionOperation = $"Result: '20 - 5 = {subtractionResult}'";

            if (subtractionResult == 15)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{subtractionOperation}{TEXT_IS_CORRECT}");
                Console.WriteLine(TEXT_TEST_PASSED);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{subtractionOperation}{TEXT_IS_WRONG}");
                Console.WriteLine(TEXT_TEST_FAILED);
                Console.ResetColor();
            }

            // **********************************************************************************************
            // Test Division
            // **********************************************************************************************
            Console.WriteLine("Try to test Method 'Division'");
            var divisionResult = basicOperations.Division(100, 5);
            var divisionOperation = $"Result: '100 / 5 = {divisionResult}'";

            if (divisionResult == 20)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{divisionOperation}{TEXT_IS_CORRECT}");
                Console.WriteLine(TEXT_TEST_PASSED);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{divisionOperation}{TEXT_IS_WRONG}");
                Console.WriteLine(TEXT_TEST_FAILED);
                Console.ResetColor();
            }

            // **********************************************************************************************
            // Test Division by zero
            // **********************************************************************************************
            Console.WriteLine("Try to test Method 'Division' by zero");

            try
            {
                basicOperations.Division(100, 0);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(TEXT_TEST_FAILED);
                Console.ResetColor();
            }
            catch (ZeroDivisorNotAllowedException)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(TEXT_TEST_PASSED);
                Console.ResetColor();
            }

            // **********************************************************************************************
            // Test Multiplication
            // **********************************************************************************************
            Console.WriteLine("Try to test Method 'Multiplication'");
            var multiplicationResult = basicOperations.Multiplication(5, 10);
            var multiplicationOperation = $"Result: '5 * 10 = {multiplicationResult}'";

            if (multiplicationResult == 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{multiplicationOperation}{TEXT_IS_CORRECT}");
                Console.WriteLine(TEXT_TEST_PASSED);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{multiplicationOperation}{TEXT_IS_WRONG}");
                Console.WriteLine(TEXT_TEST_FAILED);
                Console.ResetColor();
            }

            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
        }
    }
}