namespace HQSP_Assignment_1_Task_2
{
    //Task 2 - Total money spent on watching games

    internal class Program
    {

        //Initializing the variables
        static int PurplePrice = 50;
        static int GreenPrice = 80;
        static int BluePrice = 100;

        static void Main(string[] args)
        {
           
        }

        static int GetNumberOfTickets(string ticketType)
        {
            Console.Write("Enter the number of ticket type bought: " + ticketType);
            return int.Parse(Console.ReadLine());
        }

        static int CalculateTotalMoneySpent(int purpleTickets, int greenTickets, int blueTickets)
        {
            return (purpleTickets) + (greenTickets) + (blueTickets);
        }

        static int CalculateAverageMoneySpent(int totalSpent, int totalTickets)
        {
            return totalTickets > 0 ? 
                   totalSpent / totalTickets : 0;
        }

        static void DisplayResult(int totalMoneySpent, int averageSpent)
        {
            Console.WriteLine("Total money spent: $" + totalMoneySpent );
            Console.WriteLine("Average price calculation per game: $" + averageSpent);
        }
    }
}