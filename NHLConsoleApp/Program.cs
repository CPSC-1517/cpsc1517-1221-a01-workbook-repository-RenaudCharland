using NHLSystemClassLibrary;

namespace NHLConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.Write("Enter a team name: ");
                //string teamName = Console.ReadLine();
                Team oilers = new Team("Maple leafs", "Edmonton", "Rogers Place", Conference.Western, Division.Pacific);
                Console.WriteLine(oilers);
                //Console.WriteLine($"Name: {oilers.Name}, City: {oilers.City}, Arena: {oilers.Arena}");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}