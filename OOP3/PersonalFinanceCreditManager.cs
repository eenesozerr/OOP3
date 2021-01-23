using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ihtiyac kredisi odeme plani hesaplandi.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}

