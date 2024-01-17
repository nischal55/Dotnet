using System;
namespace InstanceMethod1{
    class A{
        public void InstanceMethod(){
            System.Console.WriteLine("Instance Method");
        }
        public static void staticMethod(){
            System.Console.WriteLine("Static Method");
        }

    }
    class InstanceMethod1{
        delegate void Del();
        static void Main(){
            A objA= new A();
            Del d = objA.InstanceMethod;
            d();
            d = A.staticMethod;
            d();
        }
    }
}