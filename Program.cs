




var sarath = new Person("Sarath", "sarath@gmail.com", new DateOnly(1997, 09, 25));

var anoop = new Person("Anoop", "anoop@gmail.com", new DateOnly(1997, 09, 25));

sarath.Vehicle.Add(new Bike("R15", "Yamaha", 2007));

sarath.Vehicle.Add(new Car("800", "Alto", 1999));

anoop.Vehicle.Add(new Bike("MT15", "Yamaha", 2010));

List<Person> peoples = [sarath, anoop];

foreach (var people in peoples)
{
    foreach (var vehicle in people.Vehicle)
    {
        Console.WriteLine($"{people.Name} has {vehicle}");
    }

}


public abstract class Vehicle(string name, string model, int year)
{
    public string Name { get; } = name;

    public string Model { get; } = model;

    public int Year { get; } = year;

    public abstract string Wroom();

    public override string ToString()
    {
        return $"My name is {name} and i am a {GetType().Name}";
    }
}

public class Car(string name, string model, int year) : Vehicle(name, model, year)
{
    public override string Wroom() => "Wroom";
}

public class Bike(string name, string model, int year) : Vehicle(name, model, year)
{

    public override string Wroom() => "Weee";
}

public class Person(string name, string email, DateOnly birthday)
{
    public string Name { get; } = name;

    public string Email { get; } = email;

    public DateOnly Birthday { get; } = birthday;

    public List<Vehicle> Vehicle = new();
}

