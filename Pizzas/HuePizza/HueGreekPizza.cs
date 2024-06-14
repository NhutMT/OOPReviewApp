namespace PizzaStore.Pizzas.HuePizza;
using PizzaStore.Pizzas.Base;

public class HueGreekPizza : Pizza
{
    public HueGreekPizza()
    {
        name = "HUE The Best Greek pizza";
        dough = "HUE Thin dough";
        sauce = "HUE Chilli sauce";
        toppings.Add("Black olives");
        toppings.Add("Tomato");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
