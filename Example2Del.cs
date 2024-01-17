using System;
namespace Example2Del{
    delegate int NumberChanger(int n);
    class Example2Del{
        static int  num =10;
        public static int AddNum(int p){
            num+=p;
            return num;

        }
        public static int MultNum(int q){
            num *= q;
            return num;
        }
        public static int getNum(){
            return num;
        }
        static void Main(){
            NumberChanger no1 = new NumberChanger(AddNum);
             NumberChanger no2 = new NumberChanger(MultNum);

            //  no1(25);
             System.Console.WriteLine(no1(25));
             System.Console.WriteLine("Value of Num: {0}",getNum());
             no2(5);
             System.Console.WriteLine("Value of Num: {0}",getNum());
        }

    }
}