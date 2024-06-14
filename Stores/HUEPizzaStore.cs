namespace PizzaStore.Stores;

using PizzaStore.Pizzas.Base;
using PizzaStore.Pizzas.HuePizza;
using PizzaStore.Stores.Base;

public class HUEPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        switch (type)
        {
            case "cheese":
                return new HueCheesePizza();
            case "greek":
                return new HueGreekPizza();
            case "pepperoni":
                return new HuePepperoniPizza();
            default:
                Console.WriteLine("We dont have that pizza!");
                return null;
        }
    }
}
