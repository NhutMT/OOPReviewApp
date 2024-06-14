namespace PizzaStore;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        name = "The Best cheese pizza";
        dough = "Very thin dough";
        sauce = "Very spicy sauce";
        toppings.Add("Black olives");
        toppings.Add("Cheese");
    }
    public override void Box()
    {
        // base.Box();
        Console.WriteLine(dough);
    }
}
