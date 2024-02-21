namespace Linq{
    class Linq{
        static void Main(){
            List<int> marks = new List<int>{10,30,50,20,5};
            int max = marks.Max();
            int min = marks.Min();
            int sum = marks.Sum();
            int count = marks.Count();
            
            Console.WriteLine(max);

        }
    }
}
