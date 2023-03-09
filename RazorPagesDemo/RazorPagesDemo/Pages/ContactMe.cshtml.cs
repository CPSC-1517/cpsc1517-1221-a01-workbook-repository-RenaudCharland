using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class ContactMeModel : PageModel
    {
        [BindProperty]
        public string? ContactName { get; set; }
        [BindProperty]
        public string? ContactEmail { get; set; }
        [BindProperty]
        public string? ContactComments { get; set; }
        [BindProperty]
        public bool? SubscribeToMail { get; set; }
        
        public string? InfoMessage { get; private set; }
        public string? ErrorMessage { get; private set; }

        public void OnPostSendMessage()
        {
            string subscribedToMail = (SubscribeToMail is null) ? "Yes" : "No";
            InfoMessage = $"Name: {ContactName} <br />" + $"Email: {ContactEmail} <br />" + $"Comments: {ContactComments}" + $"Subscribed to mail: {subscribedToMail}";
        }

        public IActionResult OnPostClear()
        {
            ContactName = null;
            ContactEmail = null;
            ContactComments = null;
            SubscribeToMail = false;
            return RedirectToPage();
        }
        public void OnPost()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ContactName))
                {
                    ErrorMessage = "Name Cannot be blank";
                }
                if (string.IsNullOrWhiteSpace(ContactEmail))
                {
                    ErrorMessage = "Email Cannot be blank";
                }
            }catch(Exception ex)
            {
                ErrorMessage = $"{ex.Message}";
            }
        }
    }
}
