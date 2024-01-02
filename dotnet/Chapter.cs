using System;
namespace Ch_3{
    class Person{
        private string name;
        private string age;

        public Person(string personName, string personAge ){
            name=personName;
            age=personAge;
        }
        public void displayInfo(){
            System.Console.WriteLine($"Name:{this.name}"+ $"Age:{this.age}");
        }
        public static void displayName(){
            System.Console.WriteLine("hello");
        }
        ~Person(){
            System.Console.WriteLine("Destructor called");
        }

      

    }
    class Ch_3{
        static void Main(){
            Person person1=new Person("Nischal","21");
            person1.displayInfo();

            Person person2=new Person("Dev","21");
            person2.displayInfo();

            Person.displayName();
        }
    }
}
