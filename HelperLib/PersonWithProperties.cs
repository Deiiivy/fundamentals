public class PersonWithProperties
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public void IntroduceOneSelf()
    {
        Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old.");
    }
}