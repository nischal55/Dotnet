namespace JoinEg{
    class JoinEg{
        static void Main(){
            List<string> names = new List<string>() {"Ram","Hari","Shyam"};
            List<string> addres = new List<string>() {"Ram","Bhkt","Lalit"};
             
            var resultJoin = names.Join(
                addres,
                str1 => str1,
                str2 => str2,
                (str1,str2) => str2
            );
            foreach(var res in resultJoin){
                System.Console.WriteLine(res);
            }

        }
    }
}