using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_CashFlowManager
{
    class HourlyEmployee : Employee
    {
       

        

        private decimal _hourlyWage;
        private int _hoursWorked;
        
        public int HoursWorked
        {
            get { return _hoursWorked; }
            
        }

        public decimal HourlyWage
        {
            get { return _hourlyWage; }

        }

        public HourlyEmployee(string first, string last, string SSN, decimal hourlyWage, int hoursWorked) : base(first, last, SSN)
        {
            _hourlyWage = hourlyWage;
            _hoursWorked = hoursWorked;


        }
        public override IPayable.LedgerType GetLedgerType()
        {
            return IPayable.LedgerType.Hourly;
        }
        public override decimal Earnings()
        {
            if (HoursWorked > 40)
            {
                int overTime = HoursWorked - 40;
                decimal earnings = 40 * HourlyWage;
                return earnings += overTime * (HourlyWage * 1.5m);

            }
            else
            {
                return HoursWorked * HourlyWage;
            }
               

        }
        public override string ToString()
        {

            return "Hourly employee: " + FirstName + " " + LastName +
                   "\nSSN: " + SSN +
                   "\nHourly wage Salary: " + HourlyWage.ToString("C") +
                   "\nHours Worked: " + HoursWorked +
                   "\nEarned: " + Earnings().ToString("C");
                
        }
    }
}
