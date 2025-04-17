public class Burger
{
    private List<string> _parts = new List<string>();
    public void Add(string part) => _parts.Add(part);
    public string ListParts() => $"Burger mit: {string.Join(", ", _parts)}";
}

public interface IBurgerBuilder
{
    void AddBun();
    void AddPatty();
    void AddCheese();
    void AddLettuce();
    Burger GetBurger();
}

public class BurgerBuilder : IBurgerBuilder
{
    private Burger _burger = new Burger();
    public void AddBun() => _burger.Add("Brötchen");
    public void AddPatty() => _burger.Add("Fleisch");
    public void AddCheese() => _burger.Add("Käse");
    public void AddLettuce() => _burger.Add("Salat");
    public Burger GetBurger()
    {
        var result = _burger;
        _burger = new Burger(); // reset
        return result;
    }
}
