using NHLSystemClassLibrary;
using System.Security.Cryptography.X509Certificates;

namespace NHLConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    //Console.Write("Enter a team name: ");
            //    //string teamName = Console.ReadLine();
            //    Team oilers = new Team("Maple leafs", "Edmonton", "Rogers Place", Conference.Western, Division.Pacific);
            //    Console.WriteLine(oilers);
            //    //Console.WriteLine($"Name: {oilers.Name}, City: {oilers.City}, Arena: {oilers.Arena}");
            //}
            //catch(ArgumentNullException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //create a new array with the names of 12 of your favourite game titles
            string[] favGameTitles =
            {
                "World of Warcraft",
                "Elden Ring",
                "Predecessor",
                "Rocket League",
                "Grounded",
                "Destiny 2",
                "Ready or Not",
                "Forza Horison 5",
                "Doom Eternal",
                "Sea of Thieves",
                "High on Life",
                "Assassins Creed Black Flag"
            };
            //print the name of each game title using a foreach loop
            foreach (string game in favGameTitles)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine();
            //print the name of each game title using a for loop
            for (int i = 0; i < favGameTitles.Length; i++)
            {
                Console.WriteLine(favGameTitles[i]);
            }
            Console.WriteLine();
            //print the name of each title using the LinQ Enumerable forEach Method
            favGameTitles.ToList().ForEach(game => Console.WriteLine(game));
            Console.WriteLine();
            //Sort the game titles in ascending order then print the the name of each game
            favGameTitles.OrderBy(game => game).ToList().ForEach(game => Console.WriteLine(game));
            Console.WriteLine();
            //use the LinQ Enumerable method where to include only gmaes with the of keyword
            favGameTitles.Where(game => game.Contains("of")).ToList().ForEach(game => Console.WriteLine(game));
            Console.WriteLine();
            // Using the LinQ Enumerable method Any() to determine if any games contains the Elden Ring Title
            bool eldenRingTitle = favGameTitles.Any(game => game.Contains("Elden Ring"));
            if (eldenRingTitle)
            {
                Console.WriteLine("Yes there are games with the title Elden Ring");
            }
            Console.WriteLine();
            //using the LinQ Enumerable method First() to return the first game with the title "Destiny 2"
            string? gameTitle = favGameTitles.First(game => game.Contains("Destiny 2"));
            Console.WriteLine(gameTitle);
        }
    }
}