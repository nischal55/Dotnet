using System;
namespace Delegate{
    public delegate void AddDelegate(int x, int y);
    public delegate string Saydelegate(string str);
    
    class Delegate{
        public void AddNums(int a, int b){
            Console.WriteLine(a+b);
        }
        public static string sayHello(string name){
            return "Hello"+name;
        }
        static void Main(){
            Delegate p = new Delegate();
            AddDelegate ad =new AddDelegate(p.AddNums);
            ad(100,50);
            Saydelegate sd =new Saydelegate(Delegate.sayHello);
            string str = sd("Raju");
            Console.WriteLine(str);
        }
    }
}