﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace NhlWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //define an auto-implemented property for username
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public int? Age { get; set; }
        [BindProperty]
        public string? DmitStream { get; set; }
        [BindProperty]
        public string other { get; set; }
        //define an auto-implemented property for feedback messages
        public string? InfoMessage { get; private set; }

        public void OnPost()
        {
            //generate a lucky number between 1 and 50 (inclusive)
            //send a feedback message with format:
            //"hello {username}. your lucky number is {luckynumber}"
            Random rnd = new Random();
            int randomNumber = rnd.Next(1,51);
            InfoMessage = $"Hello {Username}. Your lucky number is {randomNumber}";
            InfoMessage += $" You are {Age} years old.";
            InfoMessage += $" You are in {DmitStream}.";
        }

        public void OnGet()
        {

        }
    }
}