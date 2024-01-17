using System;
namespace multicast{
public class multicast{
	public delegate void SimpleDelegate(string message);
	public static void Method1(string message){
		Console.WriteLine($"Method 1: {message}");
	}
	public static void Method2(string message){
		Console.WriteLine($"Method 2: {message}");	
	}
static void Main(){
SimpleDelegate simpleDelegate = new SimpleDelegate(Method1);
simpleDelegate += Method2;
simpleDelegate("Hello from multicast delegate");
simpleDelegate -= Method2;
simpleDelegate("Hello from multicast delegate");
}
}
}

