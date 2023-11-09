using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class ApplicationManager
    {
        //Method Injection
        public void Apply(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void ProvideCreditInformation(List<ICreditManager> loans)
        {
            foreach (var credit in loans)
            {
                credit.Calculate();
            }
        }
    }
}
