namespace PizzaStore.Pizzas.DNPizza;
using PizzaStore.Pizzas.Base;

public class DNPepperoniPizza : Pizza
{
    public DNPepperoniPizza()
    {
        name = "DN The Best cheese pizza";
        dough = "DN Very thick dough";
        sauce = "DN Sweet sauce";
        toppings.Add("Tomato");
        toppings.Add("Cheese");
    }
    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
