using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaWebsite.Pages.Checkout
{
    [BindProperties(SupportsGet = true)] //To bind all the property in the class.
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }

        public void OnGet()
        {

            if (string.IsNullOrWhiteSpace(PizzaName))
                PizzaName = "Custom";
            if (string.IsNullOrWhiteSpace(ImageTitle))
                ImageTitle = "Create";

        }
    }
}
