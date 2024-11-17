namespace SwitchStatementScenarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Switch Statement Examples in C#!");

            // Example 1: Employee Performance Ratings
            Console.WriteLine("\n=== Example 1: Employee Performance Ratings ===");
            EvaluateEmployeePerformance(4);

            // Example 2: Evaluating Work Hours with Relational Patterns
            Console.WriteLine("\n=== Example 2: Evaluating Work Hours ===");
            EvaluateWorkHours(45);

            // Example 3: Grouping Cases for Shared Behavior
            Console.WriteLine("\n=== Example 3: Grouping Cases ===");
            EvaluateSpecialWorkHours(55);

            // Example 4: Menu for Account Management
            Console.WriteLine("\n=== Example 4: Menu for Account Management ===");
            HandleMenu();

            // Bonus: Switch Expressions
            Console.WriteLine("\n=== Bonus: Switch Expressions ===");
            UseSwitchExpression(35);

            Console.WriteLine("\nThank you for exploring switch statements in C#!");
        }

        // Example 1: Employee Performance Ratings
        static void EvaluateEmployeePerformance(int rating)
        {
            switch (rating)
            {
                case 5:
                    Console.WriteLine("Outstanding performance!");
                    break;
                case 4:
                    Console.WriteLine("Excellent performance!");
                    break;
                case 3:
                    Console.WriteLine("Good performance.");
                    break;
                case 2:
                    Console.WriteLine("Needs improvement.");
                    break;
                case 1:
                    Console.WriteLine("Unsatisfactory performance.");
                    break;
                default:
                    Console.WriteLine("Invalid rating.");
                    break;
            }
        }

        // Example 2: Evaluating Work Hours with Relational Patterns
        static void EvaluateWorkHours(int workHours)
        {
            switch (workHours)
            {
                case < 30:
                    Console.WriteLine("Part-time employee. No overtime pay.");
                    break;
                case >= 30 and < 40:
                    Console.WriteLine("Standard hours. Regular pay.");
                    break;
                case 40:
                    Console.WriteLine("Full-time employee. Eligible for overtime pay.");
                    break;
                default:
                    Console.WriteLine("Invalid work hours.");
                    break;
            }
        }

        // Example 3: Grouping Cases for Shared Behavior
        static void EvaluateSpecialWorkHours(int workHours)
        {
            switch (workHours)
            {
                case < 20:
                case > 50:
                    Console.WriteLine("Special work hours. Review schedule.");
                    break;
                case >= 20 and <= 50:
                    Console.WriteLine("Standard work hours.");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }

        // Example 4: Menu for Account Management
        static void HandleMenu()
        {
            Console.WriteLine("Select an action: ");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Update Account");
            Console.WriteLine("3. Delete Account");

            string selectedAction = Console.ReadLine();

            switch (selectedAction)
            {
                case "1":
                    Console.WriteLine("Creating a new account...");
                    break;
                case "2":
                    Console.WriteLine("Updating an existing account...");
                    break;
                case "3":
                    Console.WriteLine("Deleting an account...");
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        // Bonus: Switch Expressions
        static void UseSwitchExpression(int workHours)
        {
            string message = workHours switch
            {
                < 30 => "Part-time employee. No overtime pay.",
                >= 30 and < 40 => "Standard hours. Regular pay.",
                >= 40 => "Full-time employee. Eligible for overtime pay.",
               
            };

            Console.WriteLine(message);
        }
    }
}
