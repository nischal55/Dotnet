using System;
namespace Indexers{
    class IndexersExample{
        private string[] names=new string[10];
        public string this[int i]
        {
            get{
                return names[i];
            }
            set{
                names[i]=value;
            }
        }
    }
    class Indexers{
        static void Main(){
            IndexersExample Team =new IndexersExample();
            Team[0]="Nischal";
            Team[1]="Rishab";
            Team[2]="Ramesh";
            Team[3]="Dev";
            Team[4]="Mary";
            Team[5]="Ram";
            Team[6]="Hari";
            Team[7]="Rabi";
            Team[8]="Mrdev";
            Team[9]="devle";

            string[] a={"nischal","Shakya"};
            System.Console.WriteLine(a[1]);
            System.Console.WriteLine(Team[0]);
        }

    }
}


/**
    modiier-> can be private,oublic,protected or internal
    return type-> Can be any valid C# types
    this -> this is a speial keyword in c# to indicate the onbject of current class
    argument List-> The Formal argument list specifies the parameters of inedexers
**/