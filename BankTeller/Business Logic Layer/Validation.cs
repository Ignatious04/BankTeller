using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller.Business_Logic_Layer
{
    public class Validation
    {
        private int _pin = 123456;

        public bool ValidatePIN(int pin)
        {
            if (pin == _pin)
            {
                return true;
            }
            
            return false;
        }
    }
}
