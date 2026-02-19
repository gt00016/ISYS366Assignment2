using ISYS366Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISYS366Assignment2.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public PersonModel? Person { get; set; }

        public void OnGet()
        {
            _logger.LogInformation("Privacy OnGet");

            if(Person != null) 
            {
                _logger.LogInformation("Name={Name}", Person.Name);
                _logger.LogInformation("Age={Age}", Person.Age);
            }
        }

        public void OnPost() 
        {
            _logger.LogInformation("Privacy OnPost");

            if (Person != null)
            {
                _logger.LogInformation("Name={Name}", Person.Name);
                _logger.LogInformation("Age={Age}", Person.Age);
            }
        }


    }

}
