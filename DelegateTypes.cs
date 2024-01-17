using System;
namespace DelegateTypes{
    class MethodCollections{
        public static void PrintTest(){
            System.Console.WriteLine("Test printed with help of action");
        }
        public static void PrintNumbers(int start,int end){
            for(int i=start; i<=end;i++){
                System.Console.WriteLine(i);
            }
        }
        public static void Print(string message){
            System.Console.WriteLine(message);
        }
        public static int Addition(int a,int b){
            return a+b;
        }
        public static string DisplayAddition(int a,int b){
            return string.Format("Addition of {0} and {1} is {2}",a,b,a+b);
        }
        public static string showCompleteName(string firstName,string lastName){
            return string.Format("Your name is {0} {1}",firstName,lastName);
        }
        public static int showNumbers(){
            Random r= new Random();
            return r.Next();
        }
    }

    class DelegateTypes{
        static void Main(){
            Action printTest =new Action(MethodCollections.PrintTest);
            Action<int, int> printNumbers =new Action<int,int>(MethodCollections.PrintNumbers);
            Action<string> print = new Action<string>(MethodCollections.Print);

            Func<int,int,int> add1 = new Func<int,int,int>(MethodCollections.Addition);
            Func<int,int,string> add2 = new Func<int, int, string>(MethodCollections.DisplayAddition);
            Func<string,string,string> completeName = new Func<string,string,string>(MethodCollections.showCompleteName);
            Func<int> random = new Func<int>(MethodCollections.showNumbers);

            System.Console.WriteLine("*************Action<> Delegate method************");
            printTest();
            print("Nischal");
            printNumbers(5,12);

            System.Console.WriteLine("************Func<> Delegate Method*************");
            int addition = add1(2,5);
            string addition2 = add2(5,8);
            string name = completeName("Nischal","Shakya");
            int randomNumbers = random();
            System.Console.WriteLine($"Addition: {addition}");
            System.Console.WriteLine(addition2);
            System.Console.WriteLine(name);
            System.Console.WriteLine($"Random Number is {randomNumbers}");
        }
    }
}