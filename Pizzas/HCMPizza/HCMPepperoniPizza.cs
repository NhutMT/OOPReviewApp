namespace PizzaStore.Pizzas.HCMPizza;
using PizzaStore.Pizzas.Base;

public class HCMPepperoniPizza : Pizza
{
    public HCMPepperoniPizza()
    {
        name = "HCM The Best cheese pizza";
        dough = "HCM Very thick dough";
        sauce = "HCM Sweet sauce";
        toppings.Add("Tomato");
        toppings.Add("Cheese");
    }
    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
