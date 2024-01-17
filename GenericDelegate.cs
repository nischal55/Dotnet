using System;
namespace GenericDelegate{
    public delegate T MyGenericDelegate<T>(T arg1,T arg2);
    public class GenericDelegate{
        public static void Main(){
            MyGenericDelegate <int> genericDelegate=(a,b)=>a+b;
            int sum = genericDelegate(5,3);
            Console.WriteLine($"sum:{sum}");
        }
    }
}