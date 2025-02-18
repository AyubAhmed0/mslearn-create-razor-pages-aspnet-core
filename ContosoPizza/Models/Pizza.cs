// This file contains the model for a Pizza, 
// which represents the structure of a pizza object that will be stored in the database.

using System.ComponentModel.DataAnnotations;  // Importing data annotations for validation, such as Required and Range.

namespace ContosoPizza.Models;  // Defines the namespace for the Pizza class, helping organize the project structure.

public class Pizza
{
    // The Id is the unique identifier for the pizza (primary key in the database).
    // It will automatically increment when a new pizza is added to the database.
    public int Id { get; set; }

    // The Name property represents the name of the pizza (e.g., "Margherita", "Pepperoni").
    // The Required data annotation ensures that the Name cannot be null or empty when creating a pizza.
    [Required]  
    public string? Name { get; set; }

    // The Size property represents the size of the pizza.
    // It uses the PizzaSize enum to restrict the values to Small, Medium, or Large.
    public PizzaSize Size { get; set; }

    // The IsGlutenFree property is a boolean value indicating whether the pizza is gluten-free.
    // It can be either true or false.
    public bool IsGlutenFree { get; set; }

    // The Price property represents the price of the pizza.
    // The Range data annotation ensures that the price is between 0.01 and 9999.99.
    [Range(0.01, 9999.99)]  
    public decimal Price { get; set; }
}

// Enum to define the possible sizes of the pizza. 
// Enums help restrict the value of the Size property to only these three values: Small, Medium, or Large.
public enum PizzaSize { Small, Medium, Large }
