using System;
namespace AbstractionExample{
   public abstract class Shape{
     public abstract double calculateInterest();
     public void DisplayInfo(){
        Console.WriteLine("Displaying the info of the Shape");
    }
   }
   public class Circle:Shape{
    public double Radius{get;set;}
    public Circle(double radius){
        Radius=radius;
    }
    public override double calculateInterest(){
        return Math.PI*Radius*Radius;
    }
   }
   class ProgramMain{
    static void Main(){
        Circle obj = new Circle(5);
        double area= obj.calculateInterest();
        
    }
   }
}



