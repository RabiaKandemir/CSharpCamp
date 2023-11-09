namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.FirstName = "Rabia";
            customer1.LastName = "Kandemir";
            customer1.TcNo = "12345678901";
            Coorporate customer2 = new Coorporate();   
            customer2.Id = 2;
            customer2.CompanyName = "Tobeto";
            customer2.CustomerNo = "12345";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}