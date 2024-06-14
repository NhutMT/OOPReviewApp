namespace PizzaStore;

public abstract class Pizza
{
    protected string name;
    protected string dough;
    protected string sauce;
    protected List<string> toppings = new List<string>();

    public void Prepare()
    {
        Console.WriteLine("Preparing " + name);
        Console.WriteLine("Tossing...");
        Console.WriteLine("Adding source...");
        Console.WriteLine("Adding toppings ");
        toppings?.ForEach(p => Console.WriteLine("\t" + p));
    }

    public void Bake()
    {
        Console.WriteLine("Baking " + name + " in 30 mins");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting ");
    }
    public virtual void Box()
    {
        Console.WriteLine("Boxing ");
    }
}
