namespace PizzaStore.Stores;

using PizzaStore.Pizzas.Base;
using PizzaStore.Pizzas.HCMPizza;
using PizzaStore.Stores.Base;

public class HCMPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        switch (type)
        {
            case "cheese":
                return new HCMCheesePizza();
            case "greek":
                return new HCMGreekPizza();
            case "pepperoni":
                return new HCMPepperoniPizza();
            default:
                Console.WriteLine("We dont have that pizza!");
                return null;
        }
    }
}
