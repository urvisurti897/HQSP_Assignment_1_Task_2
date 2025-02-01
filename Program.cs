namespace HQSP_Assignment_1_Task_2
{
    //Task 2 - Total money spent on watching games

    internal class Program
    {

        //Initializing the variables for the prices each ticket
        static int PurplePrice = 50;
        static int GreenPrice = 80;
        static int BluePrice = 100;

        //Main method where program execution starts
        static void Main(string[] args)
        {
            //Fetching the number of tickets for each type
            int purpleTickets = GetNumberOfTickets("Purple");
            int greenTickets = GetNumberOfTickets("Green");
            int blueTickets = GetNumberOfTickets("Blue");

            //Calculation of total amount of money spent 
            int totalSpent = CalculateTotalMoneySpent(purpleTickets, greenTickets, blueTickets);

            //Calculation of average money spent per ticket
            int averageSpent = CalculateAverageMoneySpent(totalSpent, purpleTickets + greenTickets + blueTickets);

            //Displaying the total money spent and average spent per ticket
            DisplayResult(totalSpent, averageSpent);
        }

        //Method to fetch number of tickets for each type
        static int GetNumberOfTickets(string ticketType)
        {
            //Prompts user to enter number of tickets for each type
            Console.Write("Enter the number of " + ticketType + " tickets bought: ");

            //Returns number of tickets specified by user
            return int.Parse(Console.ReadLine());        
        }

        //Method to calculate total money spent per ticket
        static int CalculateTotalMoneySpent(int purpleTickets, int greenTickets, int blueTickets)
        {
            //Calculating total money spent where number of tickets is multiplied by it's respective price
            int ctms = (purpleTickets * PurplePrice) + (greenTickets * GreenPrice) + (blueTickets * BluePrice);

            //Returns the calculated total money spent
            return ctms;
        }


        //Method to calculate average money spent per trip
        static int CalculateAverageMoneySpent(int totalSpent, int totalTickets)
        {
            //Returns the average money spent per ticket
            //if total tickets > 0 then calculate totalspent divides totaltickets or else return 0
            return totalTickets > 0 ? 
                   totalSpent / totalTickets : 0;
        }


        //Method to display final result
        static void DisplayResult(int totalMoneySpent, int averageSpent)
        {
            //Prints total money spent
            Console.WriteLine("Total money spent: $" + totalMoneySpent );

            //Prints average money spent per trip
            Console.WriteLine("Average price calculation per game: $" + averageSpent);
        }
    }
}