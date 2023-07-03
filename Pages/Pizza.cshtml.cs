using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaWebsite.Models;

namespace RazorPizzaWebsite.Pages
{
    public class PizzaModel : PageModel
    {
        //Note this pizzasModel is from the model pizza.
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                finalPrice=5
            },
            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce = true,
                Ham = true,
                Cheese=true,
                Beef=true,
                finalPrice=11
            },
            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce = true,
                Mushroom = true,
                Cheese=true,
                finalPrice=6
            },
            new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                Peperoni=true,
                finalPrice=7
            },
            new PizzasModel(){
                ImageTitle="Seafood",
                PizzaName="Seafood",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                Tuna=true,
                finalPrice=8
            },
            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                Pineapple=true,
                Mushroom=true,
                finalPrice=7
            },
            new PizzasModel(){
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                Ham=true,
                Mushroom=true,
                finalPrice=9
            },
            new PizzasModel(){
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                Peperoni=true,
                Pineapple=true,
                finalPrice=8
            },
            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce = true,
                Cheese=true,
                Pineapple=true,
                Beef=true,
                finalPrice=9
            },
            

        };
        public void OnGet()
        {

        }
    }
}
