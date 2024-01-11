using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class FactorialService : IFactorialService
    {
        public string GetFactorial(int number)
        {
            int input = 1;
            for (int i = 1; i <= number; i++)
            {
                input = input * i;
            }
            return "The factorial of "+number+" is "+ input;
        }
    }
}
