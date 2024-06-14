namespace PizzaStore.Pizzas.HuePizza;
using PizzaStore.Pizzas.Base;

public class HueCheesePizza : Pizza
{
    public HueCheesePizza()
    {
        name = "HUE The Best cheese pizza";
        dough = "HUE Very thin dough";
        sauce = "HUE Very spicy sauce";
        toppings.Add("Black olives");
        toppings.Add("Cheese");
    }
    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
