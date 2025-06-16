using System;
using System.Threading;

partial class Program
{
    static void Main(string[] args)
    {

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Mystical Agriculture Essence Calculator");
            Console.WriteLine("---------------------------------------");

            Console.Write("\nAmount of Essence: ");
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("\nInvalid input, please enter a numeric value.");
                Console.Write("\nAmount of Essence:");
            }

            Console.WriteLine("\nSelect the essence type: ");
            Console.WriteLine("\n1. Prudentium Essence");
            Console.WriteLine("2. Tertium Essence");
            Console.WriteLine("3. Imperium Essence");
            Console.WriteLine("4. Supremium Essence");
            Console.WriteLine("5. Insanium Essence");

            Console.Write("\nEnter your choice (1-5): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("\nInvalid Choice, please enter a Number between 1 and 5.");
                Console.Write("\nEnter your choice (1-5): ");
            }

            double result = 0;
            string essenceType = "";

            switch (choice)
            {
                case 1:
                    essenceType = "Prudentium Essence";
                    result = value * 4.0;
                    break;
                case 2:
                    essenceType = "Tertium Essence";
                    result = value * 16.0;
                    break;
                case 3:
                    essenceType = "Imperium Essence";
                    result = value * 64.0;
                    break;
                case 4:
                    essenceType = "Supremium Essence";
                    result = value * 256.0;
                    break;
                case 5:
                    essenceType = "Insanium Essence";
                    result = value * 1024.0;
                    break;
            }
            Console.WriteLine($"Type of essence: {essenceType}");
            Console.WriteLine($"Amount of Inferium needed: {result}");

            Console.Write("\nDo you want to run the calculator again? (y/n): ");
            string runInput = Console.ReadLine().Trim().ToLower();

            while (runInput != "y" && runInput != "n")
            {
                Console.WriteLine("\nInvalid input, please choose between 'y' or 'n'.");
                Console.Write("\nDo you want to run the calculator again? (y/n): ");
                runInput = Console.ReadLine().Trim().ToLower();
            }

            keepRunning = (runInput == "y");
        }
        Console.WriteLine("\nThanks for using this Calculator. Made by:");
        Console.WriteLine("\n\n               .-'''-.                                               .-'''-.                     .-'''-.     \r\n              '   _    \\                                            '   _    \\                  '   _    \\   \r\n   _..._    /   /` '.   \\      __.....__      __  __   ___   .--. /   /` '.   \\               /   /` '.   \\  \r\n .'     '. .   |     \\  '  .-''         '.   |  |/  `.'   `. |__|.   |     \\  '       _     _.   |     \\  '  \r\n.   .-.   .|   '      |  '/     .-''\"'-.  `. |   .-.  .-.   '.--.|   '      |  '/\\    \\\\   //|   '      |  ' \r\n|  '   '  |\\    \\     / //     /________\\   \\|  |  |  |  |  ||  |\\    \\     / / `\\\\  //\\\\ // \\    \\     / /  \r\n|  |   |  | `.   ` ..' / |                  ||  |  |  |  |  ||  | `.   ` ..' /    \\`//  \\'/   `.   ` ..' /   \r\n|  |   |  |    '-...-'`  \\    .-------------'|  |  |  |  |  ||  |    '-...-'`      \\|   |/       '-...-'`    \r\n|  |   |  |               \\    '-.____...---.|  |  |  |  |  ||  |                   '                        \r\n|  |   |  |                `.             .' |__|  |__|  |__||__|                                            \r\n|  |   |  |                  `''-...... -'                                                                   \r\n|  |   |  |                                                                                                  \r\n'--'   '--'                                                                                                ");
        Console.WriteLine("\nThis program will close in 5 seconds.");
        Thread.Sleep(5000);
    }
}