using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditBaseManager vehicleCredıtManager = new VehicleCredıtManager();
            ICreditBaseManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            AppealManager appealManager = new AppealManager();
            appealManager.Appeal(personalFinanceCreditManager, fileLoggerService);

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() { personalFinanceCreditManager, vehicleCredıtManager };

            //appealManager.CreditInformation(credits);
        }
    }
}
