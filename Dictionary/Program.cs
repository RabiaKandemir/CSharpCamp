namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            Console.WriteLine(myList.Count);
            myList.Add(2);
            Console.WriteLine(myList.Count);
        }
    }
}