using System.Runtime.ConstrainedExecution;

namespace TroyR_300791334_Lab__Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a console-based program for a lawn-mowing service. The lawn-mowing season lasts 20
            //weeks.The weekly fee for mowing a lot less than 400 square feet is $25.The fee for a lot that is 400
            //square feet or more, but less than 600 square feet, is $35 per week.The fee for a lot that is 600
            //square feet or over is $50 per week.Prompt the user for the length and width of a lawn, and then
            //display the weekly mowing fee, as well as the total fee for the 20 - week season.
              
            
            
            Console.WriteLine("Please enter Length of Lawn");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter Width of Lawn");
            double width = Convert.ToDouble(Console.ReadLine());

            double squareF = length * width;
            double price = 0;

            if (squareF <= 400)

            {
                price = 25;
            }
            else if (squareF >= 400 && squareF <= 600)
            {
                price = 35;
            }
            else if (squareF >= 600)
            {
                price = 50;
            }
            double seasonalFee = price * 20;

            Console.WriteLine($"The Weekly mowing fee is:{price:C}");
            Console.WriteLine($"The Seasonal mowing fee is:{seasonalFee:C}");
        }
    }
}
