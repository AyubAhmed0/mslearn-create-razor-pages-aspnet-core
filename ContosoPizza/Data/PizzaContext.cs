// This class is key to accessing the database in an object-oriented way, 
// abstracting away raw SQL queries and simplifying data management.
// PizzaContext is the class responsible for managing the connection to the SQLite database and performing operations on the Pizza data.
// By inheriting from DbContext, it can perform CRUD operations (Create, Read, Update, Delete) on the Pizza table in the database.
// DbSet<Pizza> allows you to perform operations on the Pizza model. EF Core will automatically create the Pizzas table in the SQLite database if it doesn't already exist.

using Microsoft.EntityFrameworkCore;  // Importing Entity Framework Core for working with the database.

namespace ContosoPizza.Data  // Defines the namespace for the database-related code.
{
    // The PizzaContext class inherits from DbContext.
    // DbContext is the main class responsible for interacting with the database.
    // It manages the connection to the database and includes the properties (DbSet) that represent the tables.
    public class PizzaContext : DbContext
    {
        // The constructor receives DbContextOptions, which contains database connection configurations.
        // These options are passed to the base DbContext class to initialize the connection.
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }

        // DbSet represents the collection of Pizza entities in the database.
        // This is equivalent to the 'Pizzas' table in the SQLite database.
        // The DbSet allows us to perform CRUD operations (Create, Read, Update, Delete) on the Pizza entities.
        public DbSet<ContosoPizza.Models.Pizza>? Pizzas { get; set; }
    }
}

