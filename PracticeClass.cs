using System;
namespace PracticeClass{
    class Calculator{
        public void add(int a,int b){
            Console.WriteLine(a+b);
        }

        public void add(double a,double b){
            Console.WriteLine(a+b);
        }
        
        public void sub(int a,int b){
            Console.WriteLine(a-b);
        }
        
        public void sub(double a,double b){
            Console.WriteLine(a-b);
        }
        public void multiply(int a,int b){
            Console.WriteLine(a*b);
        }
        
        public void multiply(double a,double b){
            Console.WriteLine(a*b);
            
        }
        public void division(int a,int b){
            Console.WriteLine(a/b);
        }
        
        public void division(double a,double b){
            Console.WriteLine(a/b);
        }

        
        
    }
    class PracticeClass{
        static void Main(){
            Calculator obj = new Calculator();
            obj.add(12,3);
            obj.add(1.5,1.5);
            obj.sub(12,3);
            obj.sub(2.5,1.5);
            obj.multiply(12,3);
            obj.multiply(2.5,1.5);
            obj.division(12,3);
            obj.division(2.5,1.5);

        }
    }
}