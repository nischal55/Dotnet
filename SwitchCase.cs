using System;

namespace SwitchCase{

class SwitchCase{
    static void Main(){
      Console.WriteLine("Enter the first number:");
      int a = int.Parse(Console.ReadLine());
       Console.WriteLine("Enter the Second number:");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the Operator:");
      Console.WriteLine("1.Add");
      Console.WriteLine("2.Substract");
      Console.WriteLine("3.Multiply");
      Console.WriteLine("4.Division");
       int op = int.Parse(Console.ReadLine());
       switch(op){
        case 1:
            Console.WriteLine(a+b);
            break;

        case 2:
            Console.WriteLine(a-b);
            break;

        case 3:
            Console.WriteLine(a*b);
            break;

        case 4:

            Console.WriteLine(a*b);
            break;
        

    



    
}
}}}
