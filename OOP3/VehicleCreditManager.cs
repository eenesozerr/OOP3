﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCredıtManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tasit kredisi odeme plani hesaplandi.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
