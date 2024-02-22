namespace GroupByEg{
    class StudentData{
        public int Id{get;set;}
        public string Name{get;set;}
        public string Address{get;set;}

        public StudentData(int id, string name,string address){
            Id =id;
            Name = name;
            Address = address;

        }
    }

    class GroupByEg{
        static void Main(){
            List<StudentData> list = new List<StudentData>()
            {
                new StudentData(1,"John","Ktm"),
                new StudentData(2,"Adam","Bhkt"),
                new StudentData(3,"Mike","Pkr"),
                new StudentData(4,"Andrew","Ktm"),
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