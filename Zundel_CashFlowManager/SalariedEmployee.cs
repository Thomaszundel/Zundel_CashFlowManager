using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_CashFlowManager
{
    class SalariedEmployee : Employee
    {
        private decimal _weeklySalary;

        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            
        }





        public SalariedEmployee(string first, string last, string SSN, decimal weeklySalary) : base(first, last, SSN)
        {
            _weeklySalary = weeklySalary;

        }
        public override IPayable.LedgerType GetLedgerType()
        {
            return IPayable.LedgerType.Salaried;
        }
        public override decimal Earnings()
        {
           
            return WeeklySalary;

        }
        public override string ToString()
        {
            return "Salaried employee: " + FirstName +" "+ LastName +
                   "\nSSN: " + SSN +
                   "\nWeekly Salary: " + WeeklySalary.ToString("C") +
                   "\nEarned: " + WeeklySalary.ToString("C");

        }


    }
}
