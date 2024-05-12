using HelperLib;

public class PersonWithContructor {
    public string Name {get; set;}
    public int Age {get; set; }


    public PersonWithContructor(string name, int age) {
        Name = name;
        Age = age;  
    }


    public void IntroduceOneSelf(){
        Console.WriteLine($"Hello, my name is {Name}, i have {Age} years old");
    }
}