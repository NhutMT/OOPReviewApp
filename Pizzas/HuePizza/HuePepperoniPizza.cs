namespace PizzaStore.Pizzas.HuePizza;
using PizzaStore.Pizzas.Base;

public class HuePepperoniPizza : Pizza
{
    public HuePepperoniPizza()
    {
        name = "HUE The Best cheese pizza";
        dough = "HUE Very thick dough";
        sauce = "HUE Sweet sauce";
        toppings.Add("Tomato");
        toppings.Add("Cheese");
    }
    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
