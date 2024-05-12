namespace HelperLib;

public class Person
{
    public string Name {get; set;}
    public int Age {get; set; }

    public string City {get; set; }

    public void IntroduceOneSelf()
    {
        Console.WriteLine($"Hello, my name is {Name}, i have {Age} years old and live in {City}");
    }
}
