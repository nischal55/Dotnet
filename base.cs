using System;
namespace topic{
class Base{
    public Base(int a,int b){
        System.Console.WriteLine("Value of a={0} & b={1}",a,b);
    }
}
class Derived:Base{
    public Derived(int x,int y):base(x,y){
        System.Console.WriteLine("Value of x={0} and y={1}",x,y);
    }
}
class topic{    
     static void Main(){
        Derived obj = new Derived(10,5);
    }
}
}
