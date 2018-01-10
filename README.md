# LemonadeStand

S O L I D
Single Responsibility Principle
 //In the method below, I take care to follow the Single Responsibility Principle
        // that states every class function etc. should have a single responsibility.
        // In the example below, DisplayWeeklyForecast is responsible only for the
        // writing of the forecast to the console. The unSOLID way might incorporate 
        // code located in another method, such as GenerateForecast.
public static void DisplayWeeklyForecast(List<Day> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.WriteLine("Day {0} Forecast: {1} and {2}.", 
            (i + 1), 
            list[i].Weather.ForecastedTemperature, 
            list[i].Weather.ForecastedAtmosphere);
    }
}
Liskov Substitution Principle(LSP)
// In the implementation of my Item : Cup, Lemon, SugarUnit, IceCube class / object
relationship, I use the LSP. The principle, which maintains that a child and parent 
should be interchangable without losing functionability. In the Inventory class, I interchange Item with Lemon, Cup, IceCube, and SugarUnit in the AlterItem method below:
 public List<Item> AddItem(int quantity, string type)
        {
            List<Item> list = new List<Item>();
            switch (type)
            {
                case "cups":
                    for(int i = 0; i < quantity; i++)
                    {
                        Cup cup = new Cup();
                        list.Add(cup);
                    }
                    return list;
                case "ice cubes":
                    for (int i = 0; i < quantity; i++)
                    {
                        IceCube iceCube = new IceCube();
                        list.Add(iceCube);
                    }
                    return list;
                case "sugar units":
                    for (int i = 0; i < quantity; i++)
                    {
                        SugarUnit sugarUnit = new SugarUnit();
                        list.Add(sugarUnit);
                    }
                    return list;
                case "lemons":
                    for(int i = 0; i < quantity; i++)
                    {
                        Lemon lemon = new Lemon();
                        list.Add(lemon);
                    }
                    return list;
                default:
                    return list;
            }
        }