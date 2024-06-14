namespace PizzaStore;

public class GreekPizza : Pizza
{
    public GreekPizza()
    {
        name = "The Best Greek pizza";
        dough = "Thin dough";
        sauce = "Chilli sauce";
        toppings.Add("Black olives");
        toppings.Add("Tomato");
    }

    public override void Box()
    {
        Console.WriteLine(name);
    }
}
