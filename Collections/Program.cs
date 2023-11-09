namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil" };
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
        }
    }
}