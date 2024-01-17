using System;
namespace unaryLab7{

    class UnaryOp{
        private int a;
        private int b;
        private int c;

        public UnaryOp(){}

        public UnaryOp(int a,int b,int c){
            this.a=a;
            this.b=b;
            this.c=c;

        }

        public void showAll(){
            System.Console.WriteLine("The first var is "+a+" The 2nd var is "+b+" the 3rd Var is "+c);
        }

        public static UnaryOp operator -(UnaryOp c1){
            UnaryOp temp=new UnaryOp();
            temp.a=-c1.a;
            temp.b=-c1.b;
            temp.c=-c1.c;
            return temp;

            //return new UnaryOp(-c1.a,-c1.b,-c1.c)
        }
        
    }
    class unaryLab7{
        static void Main(){
            UnaryOp c1=new UnaryOp(5,4,3);
            c1.showAll();
            UnaryOp c2=new UnaryOp();
            c2=-c1;
            c2.showAll();
          
        }
    }
}