namespace LinqTest
{
    class Student
    {   
        public int sid{get;set;}
        public string name{get;set;}
        public string address{get;set;}

        public Student(int sid, string name, string address){
            this.sid= sid;
            this.name = name;
            this.address = address;
        }
    }
    class LinqTest{

        static void Main(){
            System.Console.WriteLine("hello");
            List<Student> mylist = new List<Student>(){
                new Student(1,"Hari","BTM"),
                new Student(2,"Ram","Ktm"),
                new Student(3,"Shyam","Bhkt"),
                new Student(4,"Gita","Ktm")
            };
            // var result = mylist.Where(s=>s.address.Equals("Ktm")&&s.sid.Equals(2));
               var result = (from name in mylist where name.address == "Ktm" select name).OrderBy(name=>name.name);
            System.Console.WriteLine("sid\t Name \t Address");
            foreach (var res in result)
            {
                System.Console.WriteLine(res.sid +"\t"+res.name+"\t"+res.address);
            }     
            }
    }
}