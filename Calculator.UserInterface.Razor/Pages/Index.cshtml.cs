using Jarai.CSharp.Calculator.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Jarai.CSharp.Calculator.UserInterface.RazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICalculationService _calculationService;

        public IndexModel(ILogger<IndexModel> logger, ICalculationService calculationService)
        {
            _logger = logger;
            _calculationService = calculationService;
        }

        [BindProperty] public int Zahl1 { get; set; } = 100;

        [BindProperty] public int Zahl2 { get; set; } = 200;

        [BindProperty] public string Operation { get; set; } = "+";

        public string Result { get; set; }

        public void OnGet()
        {
        }


        public void OnPost()
        {
            double ergebnis = 0;

            switch (Operation)
            {
                case "+":
                    ergebnis = _calculationService.Add(Zahl1, Zahl2);
                    break;

                case "-":
                    ergebnis = _calculationService.Subtract(Zahl1, Zahl2);
                    break;

                case "*":
                    ergebnis = _calculationService.Multiply(Zahl1, Zahl2);
                    break;

                case "/":
                    ergebnis = _calculationService.Divide(Zahl1, Zahl2);
                    break;
            }

            Result = $"{Zahl1}{Operation}{Zahl2}={ergebnis}";
        }
    }
}
