using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaWebsite.Models;

namespace RazorPizzaWebsite.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty] //Now this will alow us to access custom pizzas from out CustomePizza view (i.e the html)
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 2;
            if (Pizza.Peperoni) PizzaPrice += 2;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 3;
            if (Pizza.Pineapple) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 3;
            if (Pizza.Beef) PizzaPrice += 3;

            return RedirectToPage("/Checkout/Checkout" , new { Pizza.PizzaName, PizzaPrice });
        }
    }
}
