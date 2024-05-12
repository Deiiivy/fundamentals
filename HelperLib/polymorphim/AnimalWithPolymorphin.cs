namespace HelperLib;

public class AnimalWithPolymorphin {
    public virtual void Sound(){
        Console.WriteLine($"this animal makes a sound");
    }
}


public class DogWithPolymorphism : AnimalWithPolymorphin {
    public override void Sound()
    {
        Console.WriteLine("the dog bark, guau, guau");
    }
}


public class CatWithPolymorphism : AnimalWithPolymorphin {
    public override void Sound()
    {
        Console.WriteLine("the cat bark, miau");
    }
}