namespace PizzaStore.Pizzas.DNPizza;
using PizzaStore.Pizzas.Base;

public class DNCheesePizza : Pizza
{
    public DNCheesePizza()
    {
        name = "DN The Best cheese pizza";
        dough = "DN Very thin dough";
        sauce = "DN Very spicy sauce";
        toppings.Add("Black olives");
        toppings.Add("Cheese");
    }
    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
