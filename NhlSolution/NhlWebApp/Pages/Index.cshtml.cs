using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NhlWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Define an auto-implemented property for username
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public int? Age { get; set; }
        [BindProperty]
        public string? DmitStream { get; set; } = "GP";

        // Define an auto-implemented property for feedback messages
        public string? InfoMessage { get; private set; }

        public void OnPost()
        {
            // Generate a lucky number between 1 and 50 (inclusive)
            // and send a feedback message with format:
            // "Hello {username}. You lucky number is {luckyNumber}"
            var rand = new Random();
            var randomNumber = rand.Next(1, 51);
            InfoMessage = $"Hello {Username}. You lucky number is {randomNumber} <br />";
            InfoMessage += $"You are {Age} years old. <br />";
            InfoMessage += $"You are in {DmitStream}. <br />";

        }
        public void OnGet()
        {

        }
    }
}