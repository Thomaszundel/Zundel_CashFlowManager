using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_CashFlowManager
{
    interface IPayable
    {
        decimal GetPayableAmount();
        
        public enum LedgerType
        {
            Salaried,
            Hourly,
            Invoice
        }
        LedgerType GetLedgerType();

    }
}
