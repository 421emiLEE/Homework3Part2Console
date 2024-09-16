internal class Program
{
    private static void Main(string[] args)
    {

        double change;
        double dollar = 100.00;
        double totalCents;
        double quartersNeeded;
        double dimesNeeded;
        double nickelsNeeded;

        Console.WriteLine("Enter price of item(from 25 cents to a dollar, in 5-cent increments): ");
        string userInput = Console.ReadLine();
         change = Convert.ToDouble(userInput);

        //initialize
        //change = 0;

        //processing
        totalCents = dollar - change; //1406 cents
        quartersNeeded = totalCents / 25; //.25 cents
        totalCents = totalCents % 25;
        dimesNeeded = totalCents / 10; //.10 cents
        totalCents = totalCents % 10;
        nickelsNeeded = totalCents / 5; //.05 cents
        totalCents = totalCents % 5;


        //Math.Round(quartersNeeded, 0);
        //Math.Round(dimesNeeded, 0);
        //Math.Round(nickelsNeeded, 0);

        Console.WriteLine("You bought an item for " + change + " cents and gave me a dollar, so your change is");
        Console.WriteLine((int)quartersNeeded + " quarters,");
        Console.WriteLine((int)dimesNeeded + " dimes, and");
        Console.WriteLine((int)nickelsNeeded + " nickels");
    }
}