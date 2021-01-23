using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        public void Appeal(ICreditBaseManager creditBaseManager, ILoggerService loggerService)
        {
            creditBaseManager.Calculate();
            loggerService.Log();
        }

        public void CreditInformation(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
