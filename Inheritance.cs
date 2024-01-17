using System;
namespace Inheritance{
    class Vehicle{
        public void Drive(){
            System.Console.WriteLine("Drive");
        }
    }
    public interface IEngine{
     void start();

    }
    public interface IWheels{
        void rotate();
    }
    class Car:Vehicle,IEngine{
        public void start(){
            System.Console.WriteLine("start");
        }
        public void Speedup(){
            System.Console.WriteLine("Speedup");
        }
    }
    class SuperCar:Car,IWheels{
        public void rotate(){
            System.Console.WriteLine("rotate");
        }
        public void Race(){
            System.Console.WriteLine("Race");
        }
    }

    class Inheritance{
        static void Main(){
            Car car1 =new Car();
            SuperCar car2 = new SuperCar();

            car1.start();
            car1.Speedup();
            car2.rotate();
            car2.Race();

        }
    }
   
}


//Sealed Class 
// Sealed class is defined as sealed. tis class cannot be inherited
//Sealed modifier is used to declare a sealed class
//Sealed method can be used on methods or a virtual property that overrides a virtual method or properties in the base class

//This enables you to allow classes to derive from your class & prevent oter developers that using your class from overriding specific virtual change


//