using System;
namespace InterfaceExamples{
public interface IDisplayable{
    void Display();
}
public interface Iplayable{
    void Play();
}

public class MultipleInheritance: IDisplayable,Iplayable{
    public void Display(){
        Console.WriteLine("Displaying");
    }

    public void Play(){
        Console.WriteLine("Playing");
    }

}
class Interface{
    static void Main(){
        MultipleInheritance obj = new MultipleInheritance();
        obj.Display();
        obj.Play();

    }
}
}