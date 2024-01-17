using System;

namespace Pattern{
    
    class Pattern{
        static void Main(){

   int numberoflayer = 6, Space, Number;  

Console.WriteLine("Print paramid");  

for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  

{  

    for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  

        Console.Write(" ");  

    for (Number = 1; Number < 2*i; Number++) //increase the value  

        Console.Write('*');  
        Console.WriteLine();

     

}
        }}}