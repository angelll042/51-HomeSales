using System;

class Program
{
    public static void Main(string[] args)
    {
        // Arrays for salespeople details
        string[] salespeople = { "Danielle", "Edward", "Francis" };
        char[] allowedInitials = { 'D', 'E', 'F' };
        double[] salesTotals = new double[3];  // Initialize all elements to 0 by default

        char salesperson;
        Console.WriteLine("Enter person initial (D for Danielle, E for Edward, F for Francis) or Z to terminate:");
        salesperson = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

        while (salesperson != 'Z')
        {
            int index = Array.IndexOf(allowedInitials, salesperson);
            if (index != -1)
            {
                Console.WriteLine("Enter the amount of sale:");
                double sale = Convert.ToDouble(Console.ReadLine());
                salesTotals[index] += sale;
            }
            else
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
            }

            Console.WriteLine("Enter another salesperson initial (D for Danielle, E for Edward, F for Francis) or Z to terminate:");
            salesperson = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
        }

        double grandTotal = 0;
        double highestSale = 0;
        string highestSalesperson = "";
        for (int i = 0; i < salesTotals.Length; i++)
        {
            Console.WriteLine($"{salespeople[i]}'s Total: ${salesTotals[i]}");
            grandTotal += salesTotals[i];
            if (salesTotals[i] > highestSale)
            {
                highestSale = salesTotals[i];
                highestSalesperson = salespeople[i];
            }
        }

        Console.WriteLine($"Grand Total: ${grandTotal}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
    }
}
