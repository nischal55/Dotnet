using System;
namespace GenericMethod{
    class GenericMethod{
        static void Swap<T>(ref T a, ref T b){
            T temp;
            temp=a;
            a=b;
            b=temp;
        }
        static void Main(){
            int a=40,b=60;
            System.Console.WriteLine("Before swap:"+a +" "+b);
            Swap<int>(ref a, ref b);
            System.Console.WriteLine("After swap:"+a+" "+b);

        }
    }
}