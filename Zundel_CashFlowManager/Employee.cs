using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_CashFlowManager
{
    class Employee : IPayable
    {
        
        private string _SSN;
        private string _lastName;
        private string _firstName;


        public string FirstName
        {
            get { return _firstName; }
            
        }
        public string LastName
        {
            get { return _lastName; }

        }
        public string SSN
        {
            get { return _SSN; }

        }


        public Employee(string first, string last, string SSN)
        {
            _firstName = first;
            _lastName = last;
            _SSN = SSN;
            
        }

        public virtual IPayable.LedgerType GetLedgerType()
        {
            return IPayable.LedgerType.Hourly;
        }
        public virtual decimal Earnings()
        {
            throw new System.NotImplementedException();
        }

        public decimal GetPayableAmount()
        {

            return Earnings();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
