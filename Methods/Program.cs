namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id = 1,
                Name = "Elma",
                Description = "Amasya elması",
                Price = 15,
            };
            Product product2 = new Product()
            {
                Id = 2,
                Name = "Karpuz",
                Description = "Diyarbakır karpuzu",
                Price = 80,
            };
            Product[] products= new Product[] { product1, product2 };
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("********************");
            }
            Console.WriteLine();
            Console.WriteLine("--------------Metotlar--------------");
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("Armut", "Yeşil Armut", 12,10);
            basketManager.Add2("Elma", "Yeşil Elma", 12,9);
        }
    }
}