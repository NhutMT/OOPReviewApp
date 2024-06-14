namespace PizzaStore.Pizzas.HCMPizza;
using PizzaStore.Pizzas.Base;

public class HCMCheesePizza : Pizza
{
    public HCMCheesePizza()
    {
        name = "HCM The Best cheese pizza";
        dough = "HCM Very thin dough";
        sauce = "HCM Very spicy sauce";
        toppings.Add("Black olives");
        toppings.Add("Cheese");
    }
    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
