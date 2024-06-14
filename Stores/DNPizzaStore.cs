namespace PizzaStore.Stores;

using PizzaStore.Pizzas.Base;
using PizzaStore.Pizzas.DNPizza;
using PizzaStore.Stores.Base;

public class DNPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        switch (type)
        {
            case "cheese":
                return new DNCheesePizza();
            case "greek":
                return new DNGreekPizza();
            case "pepperoni":
                return new DNPepperoniPizza();
            default:
                Console.WriteLine("We dont have that pizza!");
                return null;
        }
    }
}
