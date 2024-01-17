using System;
namespace Constructor{
   public class Constructor{
        public  int a;
        public int b;

        public Constructor(){
            this.a=1;
        }

        public Constructor(int numa, int numb){
            this.a=numa;
            this.b=numb;
        }

       
    }
    class Example{
        static void Main(){
            Constructor obj = new Constructor();
            int a=obj.a;
            System.Console.WriteLine(a);

            Constructor obj2 = new Constructor(1,2);
            System.Console.WriteLine(obj2.b);


            
        }
    }
}