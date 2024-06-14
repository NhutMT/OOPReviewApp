namespace PizzaStore.Pizzas.DNPizza;
using PizzaStore.Pizzas.Base;

public class DNGreekPizza : Pizza
{
    public DNGreekPizza()
    {
        name = "DN The Best Greek pizza";
        dough = "DN Thin dough";
        sauce = "DN Chilli sauce";
        toppings.Add("Black olives");
        toppings.Add("Tomato");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing " + name);
    }
}
