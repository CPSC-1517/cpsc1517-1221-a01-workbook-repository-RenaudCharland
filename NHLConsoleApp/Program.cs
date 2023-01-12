using NHLsolution;

namespace NHLConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a team name: ");
                string teamName = Console.ReadLine();
                Team team = new Team(teamName);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}