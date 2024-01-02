using System;
using System.Runtime.InteropServices.ObjectiveC;
namespace Recursion{


    class Recursion{
     public int factorial(int num)
    {
        // termination condition
        if (num == 0)
            return 1;
        else
            // recursive call
            return num * factorial(num - 1);
    }
        static void Main(){
            Recursion obj=new Recursion();
            int a =obj.factorial(5);
            System.Console.WriteLine(a);

        }
    }
}