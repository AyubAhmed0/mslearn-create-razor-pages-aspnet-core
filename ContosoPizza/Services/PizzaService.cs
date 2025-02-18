// PizzaService: Contains the business logic for interacting with pizza data. It abstracts away the direct interaction with the database.
// The PizzaService class acts as a service layer that provides higher-level methods to interact with the pizza data.
// It uses the PizzaContext to interact with the database and perform operations like adding, retrieving, and deleting pizzas.
// Dependency Injection is used to provide an instance of PizzaContext to this service, which is a good practice for testability and maintainability.
// This class is central to managing pizza data, as it directly interacts with the database through the PizzaContext.

using ContosoPizza.Data;  // Importing the PizzaContext to interact with the database.
using ContosoPizza.Models;  // Importing the Pizza model to manage pizza data.

namespace ContosoPizza.Services  // Defines the namespace for service-related logic.
{
    // The PizzaService class provides business logic for managing pizzas.
    // It interacts with the PizzaContext to retrieve, add, and delete pizza data from the database.
    public class PizzaService
    {
        // Private readonly field to store the instance of PizzaContext.
        // It's initialized through dependency injection in the constructor.
        private readonly PizzaContext _context = default!;

        // Constructor that receives the PizzaContext instance and initializes the _context field.
        // This uses Dependency Injection to provide the context.
        public PizzaService(PizzaContext context)
        {
            _context = context;
        }

        // Method to retrieve all pizzas from the database.
        // It checks if the Pizzas DbSet is not null and then returns a list of all pizzas.
        // If no pizzas are found, it returns an empty list.
        public IList<Pizza> GetPizzas()
        {
            if (_context.Pizzas != null)
            {
                return _context.Pizzas.ToList();  // Retrieves all pizzas from the database as a list.
            }
            return new List<Pizza>();  // Returns an empty list if no pizzas are found.
        }

        // Method to add a new pizza to the database.
        // It checks if the Pizzas DbSet is not null, adds the pizza, and then saves changes to the database.
        public void AddPizza(Pizza pizza)
        {
            if (_context.Pizzas != null)
            {
                _context.Pizzas.Add(pizza);  // Adds the new pizza to the DbSet.
                _context.SaveChanges();  // Saves the changes to the database.
            }
        }

        // Method to delete a pizza by its ID.
        // It searches for the pizza by its ID, removes it from the DbSet if found, and saves the changes.
        public void DeletePizza(int id)
        {
            if (_context.Pizzas != null)
            {
                var pizza = _context.Pizzas.Find(id);  // Finds the pizza by ID.
                if (pizza != null)
                {
                    _context.Pizzas.Remove(pizza);  // Removes the pizza from the DbSet.
                    _context.SaveChanges();  // Saves the changes to the database.
                }
            }
        }
    }
}

