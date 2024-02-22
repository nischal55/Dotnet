namespace AdvLinq{
    class Student{
        public int Id{get;set;}
        public string Name{get;set;}
        public string Address{get;set;}
        public string CourseID{get;set;}


        public Student(int id, string name,string address,int courseid){
            Id =id;
            Name = name;
            Address = address;
            CourseID = courseid;
        }
    }

    class AdvLinq{
        static void Main(){
            List<Student> list = new List<Student>()
            {
                new Student(1,"John","Ktm"),
                new Student(2,"Adam","Bhkt"),
                new Student(3,"Mike","Pkr"),
                new Student(4,"Andrew","Ktm"),
            };

            var result = list.GroupBy(student=>student.Address);
            foreach(var group in result){
                System.Console.WriteLine("Group key "+ group.Key);
                System.Console.WriteLine("id\tName\tAddress");

                foreach(var student in group){
                    System.Console.WriteLine(student.Id + "\t"+ student.Name +"\t"+ student.Address);
                }
            }
        }
    }
}