namespace PizzaStore.Pizzas.HCMPizza;
using PizzaStore.Pizzas.Base;

public class HCMGreekPizza : Pizza
{
    public HCMGreekPizza()
    {
        name = "HCM The Best Greek pizza";
        dough = "HCM Thin dough";
        sauce = "HCM Chilli sauce";
        toppings.Add("Black olives");
        toppings.Add("Tomato");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
