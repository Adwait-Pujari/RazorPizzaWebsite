using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaWebsite.Data;
using RazorPizzaWebsite.Models;

namespace RazorPizzaWebsite.Pages.Checkout
{
    [BindProperties(SupportsGet = true)] //To bind all the property in the class.
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }


        private readonly ApplicationDBContext _context;
        //Every service we want to use will get injected in constructor after proviidng the given parameter.
        public CheckoutModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

            if (string.IsNullOrWhiteSpace(PizzaName))
                PizzaName = "Custom";
            if (string.IsNullOrWhiteSpace(ImageTitle))
                ImageTitle = "Create";

            PizzaOrder pizzaOrder = new PizzaOrder();
            //Since ID is primary key we dont need write that.
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);

            //Always have to save the database
            _context.SaveChanges();
        }
    }
}
