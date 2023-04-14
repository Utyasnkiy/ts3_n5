using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Ocean atlantic = new Ocean("Atlantic", 8376);
        Island hawaii = new Island("Hawaii", 1400000);
        Mainland asia = new Mainland("Asia", 44579000);

        Planet earth = new Planet("Earth", 7, atlantic, hawaii);
        earth.DisplayContinentName(asia);
        earth.DisplayPlanetName();
        earth.DisplayNumMainlands();
    }
}

class Planet
{
    public string Name { get; set; }
    public int NumMainlands { get; set; }
    public Ocean Ocean { get; set; }
    public Island Island { get; set; }

    public Planet(string name, int numMainlands, Ocean ocean, Island island)
    {
        Name = name;
        NumMainlands = numMainlands;
        Ocean = ocean;
        Island = island;
    }

    public void DisplayContinentName(Mainland continent)
    {
        Console.WriteLine($"Continent name: {continent.Name}");
    }

    public void DisplayPlanetName()
    {
        Console.WriteLine($"Planet name: {Name}");
    }

    public void DisplayNumMainlands()
    {
        Console.WriteLine($"Number of mainlands: {NumMainlands}");
    }
}

class Mainland
{
    public string Name { get; set; }
    public int Area { get; set; }

    public Mainland(string name, int area)
    {
        Name = name;
        Area = area;
    }

    public void DisplayArea()
    {
        Console.WriteLine($"Continent {Name} area: {Area}");
    }
}

class Ocean
{
    public string Name { get; set; }
    public int Depth { get; set; }

    public Ocean(string name, int depth)
    {
        Name = name;
        Depth = depth;
    }

    public void DisplayDepth()
    {
        Console.WriteLine($"Ocean {Name} depth: {Depth}");
    }
}

class Island
{
    public string Name { get; set; }
    public int Population { get; set; }

    public Island(string name, int population)
    {
        Name = name;
        Population = population;
    }

    public void DisplayPopulation()
    {
        Console.WriteLine($"Island {Name} population: {Population}");
    }
}
