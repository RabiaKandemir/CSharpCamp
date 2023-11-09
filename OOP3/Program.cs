namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCredit = new PersonalFinanceCreditManager();
            ICreditManager transportCredit = new TransportCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();
            ApplicationManager applicationManager = new ApplicationManager();
            ILoggerService databaseLoggerService= new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            //applicationManager.Apply(personalFinanceCredit, databaseLoggerService);
            List<ICreditManager> loans = new List<ICreditManager>() { personalFinanceCredit,transportCredit};
            //applicationManager.ProvideCreditInformation(loans);
            applicationManager.Apply(new ArtisanCreditManager(), new List<ILoggerService> { databaseLoggerService,new SmsLoggerService()});

        }
    }
}