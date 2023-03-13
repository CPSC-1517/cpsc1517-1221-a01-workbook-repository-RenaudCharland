using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages
{
    public class SimpleCalculatorModel : PageModel
    {
        [BindProperty]
        public Calculator CurrentCalculator { get; set; }

        public string? InfoMessage { get; private set; }
        public string? ErrorMessage { get; private set; }

        public void OnPostAdd()
        {
            InfoMessage = $"{CurrentCalculator.Num1} + {CurrentCalculator.Num2} = {CurrentCalculator.Add()}";
        }

        public void OnPostSubtract()
        {
            InfoMessage = $"{CurrentCalculator.Num1} - {CurrentCalculator.Num2} = {CurrentCalculator.Subtract()}";
        }

        public void OnPostMultiply()
        {
            InfoMessage = $"{CurrentCalculator.Num1} * {CurrentCalculator.Num2} = {CurrentCalculator.Multiply()}";
        }

        public void OnPostDivide()
        {
            try
            {
                InfoMessage = $"{CurrentCalculator.Num1} / {CurrentCalculator.Num2} = {CurrentCalculator.Divide()}";
            }
            catch(Exception ex)
            {
                ErrorMessage = $"{ex.Message}";
            }
        }

        public void OnGet()
        {
        }
    }
}
