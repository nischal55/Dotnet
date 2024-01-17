using System;
//properties : Properties looks like fields from outside but internally they contain logic like methods
//Indexers : Indexers provides a natural syntax for assuming elements in a class or struct encapsulate a list or dictionary of value.
namespace GetSet{
    class GetSet{
        private string name{get;set;}

    

static void Main(){

    GetSet obj = new GetSet();
    obj.name="Nischal";
    System.Console.WriteLine(obj.name);
}

}
}