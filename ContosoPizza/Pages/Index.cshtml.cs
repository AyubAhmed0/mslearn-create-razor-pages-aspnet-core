// The PageModel that provides backend logic for the Razor page. 
// It currently only has an OnGet method, which runs when the page is requested via a GET request.
// Contains the backend logic for the Razor Page. 
// It is responsible for handling HTTP requests (GET, POST) and managing any data that the page needs.

using Microsoft.AspNetCore.Mvc;  // Importing the necessary namespace for working with MVC and Razor Pages.
using Microsoft.AspNetCore.Mvc.RazorPages;  // Importing the RazorPages namespace to use the PageModel base class.

namespace ContosoPizza.Pages  // Defining the namespace for the Razor Pages in the project.
{
    // IndexModel is the PageModel for the Index.cshtml Razor page. It contains the logic for handling HTTP requests (GET, POST) and data interaction for the page.
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;  // Logger to log information or errors in the page lifecycle.

        // Constructor to inject the logger service into this page model. 
        // This allows us to log events or errors in the application.
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;  // Assigning the injected logger to the private field.
        }

        // The OnGet method is called when a GET request is made to the Index.cshtml page.
        // This method will execute any logic needed before the page is rendered. 
        // Currently, no specific logic is defined here.
        public void OnGet()
        {
            // Logic for handling GET requests would go here if needed.
        }
    }
}
