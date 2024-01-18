using System;
namespace DelegateEvent{
    public delegate void DelEvent();
    class DelegateEvent{
        public static event DelEvent add;
        static void USA(){
            System.Console.WriteLine("USA");
        }
        static void India(){
            System.Console.WriteLine("India");
        }
        static void Nepali(){
            System.Console.WriteLine("Nepali");
        }
        static void Main(){
            add+=new DelEvent(USA);
            add+=new DelEvent(India);
            add+=new DelEvent(Nepali);
             
            add.Invoke();

        }

    }
}