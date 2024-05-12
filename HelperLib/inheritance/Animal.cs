namespace HelperLib;

public class Animal(){


    public void Eat(){
        Console.WriteLine($"este animal esta comiendo");
    }
}

  public class Dog : Animal {

        public void Bark(){
            Console.WriteLine("guau, guau");    
        }
    }