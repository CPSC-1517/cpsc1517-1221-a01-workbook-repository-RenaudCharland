using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class LottoQuickPicksModel : PageModel
    {
        // Define properties that can be get/set from the page
        [BindProperty]
        public string? Username { get; set; }

        [BindProperty]
        public string? LottoType { get; set; } = "Lotto649";

        [BindProperty]
        public int QuickPicks { get; set; } = 3;

        // Define properties that can be get from the page
        public string? InfoMessage { get; private set; }
        public string? ErrorMessage { get; private set; }

        public List<int[]> QuickPickNumbers { get; private set; } = new();

        // Define post handler methods
        public void OnPostGenerateNumbers()
        {
            if (string.IsNullOrWhiteSpace(Username))
            {
                ErrorMessage = "<strong>Username</strong> is required and cannot be blank.";
            }
            else
            {
                // Remove any preivous QuickPicksNumbers
                QuickPickNumbers.Clear();
                // Create a Random object for generate random numbers
                Random rand = new();
                // Create a new array of int for each quick pick
                for (int quickCount = 1; quickCount <= QuickPicks; quickCount++)
                {
                    // Generate 6 unique numbers between 1 and 49 for Lotto649
                    if (LottoType.ToUpper() == "LOTTO649")
                    {
                        int[] currentLottoQuickPicks = new int[6];
                        for (int count = 1; count <= 6; count++)
                        {
                            currentLottoQuickPicks[count - 1] = rand.Next(1, 50);
                        }
                        // Sort the contents of the array
                        Array.Sort(currentLottoQuickPicks);
                        // Add the array of int to our list
                        QuickPickNumbers.Add(currentLottoQuickPicks);
                    }
                    // Generate 7 unique numbers between 1 and 50 for LottoMAX

                }
                InfoMessage = $"Hello {Username}";
            }
        }

        public IActionResult OnPostClear()
        {
            Username = null;
            InfoMessage = null;
            ErrorMessage = null;
            return RedirectToPage();
        }

        public void OnGet()
        {
        }
    }
}
