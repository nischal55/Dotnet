using System;
namespace MulticastEx2{
    delegate int NumberChanger(int n);
    class MulticastEx2{
        static int num =10;
        public static int AddNum(int p){
            num+=p;
            return num;
        }
        public static int MultiNum(int q){
            num *= q;
            return num;
        }
        public static int getNum(){
            return num;
        }

        static void Main(){
            NumberChanger nc;
            NumberChanger nc1= new NumberChanger(AddNum);
            NumberChanger nc2= new NumberChanger(MultiNum);

            nc=nc1;
            nc+=nc2;
            nc(5);
            System.Console.WriteLine("Value of Num:{0}",getNum());
        }
    }
}