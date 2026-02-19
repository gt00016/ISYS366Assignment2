using ISYS366Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ISYS366Assignment2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public PersonModel? Person { get; set; } = new PersonModel();

        public void OnGet()
        {
            _logger.LogInformation("Index OnGet");

            if (Person != null)
            {
                _logger.LogInformation("Name={Name}", Person.Name);
                _logger.LogInformation("Age={Age}", Person.Age);
            }
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Index OnPost");

            if (Person != null)
            {
                _logger.LogInformation("Name={Name}", Person.Name);
                _logger.LogInformation("Age={Age}", Person.Age);
            }

            return RedirectToPagePreserveMethod("/Privacy"); //used AI to find this method
        }


    }
}
