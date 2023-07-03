using Microsoft.EntityFrameworkCore;
using RazorPizzaWebsite.Models;
using System.Transactions;

namespace RazorPizzaWebsite.Data
{

    //Installed Microsoft Entity Core 
    //          Microsoft Entity Core Sqlserver
    //          Microsoft Entity Core Tools 
    //          via Tools --> Nuget Package manager --> Browse
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        //Add a constructor
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            //In this options we will define the connections strings.

        }
    }
}
