using System;
namespace staticKeyword{

public class Loglvl{
public static string loglevel="Info";
}
class staticKeyword{
    //No need to create the instance of the class
    // All of the properties & method wth static keyword are binded to the class 
    static void Main(){
        System.Console.WriteLine(Loglvl.loglevel);
    }
}
}

