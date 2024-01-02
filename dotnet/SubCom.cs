using System;
namespace SubComplexOp{

    class Complex{
        private int a;
        private int b;

        public Complex(){}

        public Complex(int a,int b){
            this.a=a;
            this.b=b;

        }

        public void showAll(){
            System.Console.WriteLine("{0},{1}",a,b);
        }

        public static Complex operator -(Complex c1){
            Complex temp=new Complex();
            temp.a=-c1.a;
            temp.b=-c1.b;
            return temp;
        }
        
    }
    class SubCom{
        static void Main(){
            Complex c1=new Complex(10,20);
            c1.showAll();
            Complex c3= new Complex();
            c3=-c1;
            c3.showAll();
        }
    }
}