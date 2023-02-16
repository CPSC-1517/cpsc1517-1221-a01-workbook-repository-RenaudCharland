using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class RollDiceModel : PageModel
    {
        public void OnGet()
        {
            DiceFaceValueImage = "img/icons/ffffff/000000/1x1/delapouite/dice-shield.png";
        }

        public int DiceFaceValue { get; private set; }
        public string DiceFaceValueImage { get; private set; }

        public string[] DiceImages = 
        {
            "img/icons/ffffff/000000/1x1/delapouite/dice-six-faces-one.png",
            "img/icons/ffffff/000000/1x1/delapouite/dice-six-faces-two.png",
            "img/icons/ffffff/000000/1x1/delapouite/dice-six-faces-three.png",
            "img/icons/ffffff/000000/1x1/delapouite/dice-six-faces-four.png",
            "img/icons/ffffff/000000/1x1/delapouite/dice-six-faces-five.png",
            "img/icons/ffffff/000000/1x1/delapouite/dice-six-faces-six.png",
        };

        public void OnPost()
        {
            var rand = new Random();
            DiceFaceValue = rand.Next(1, 7);
            DiceFaceValueImage = DiceImages[DiceFaceValue - 1];
        }
    }
}
