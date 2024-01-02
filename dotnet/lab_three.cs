using System;

namespace lab_three{

    class lab_three{

         int Add(){
           
            int x= 1;
           
            int y= 2;

            int z=3;

            return x+y+z ;
        }

         int Add(int x){
            return x+1;
        }
          int Add(int x,int y){
            return x+y;
        }
          int Add(int x,int y,int z){
            return x+y+z;
        }

         static void Main(){
            lab_three obj = new lab_three();
            Console.WriteLine("Question 1");
            int ques_one = obj.Add();
            Console.WriteLine(ques_one);

            
            Console.WriteLine("Question 2");
            int ques_two =obj. Add(5);
            Console.WriteLine(ques_two);

            Console.WriteLine("Question 3");
            int ques_three = obj.Add(5,6);
            Console.WriteLine(ques_three);

            Console.WriteLine("Question 4");
            int ques_four = obj.Add(5,6,1);
            Console.WriteLine(ques_four);

        }
    }
}