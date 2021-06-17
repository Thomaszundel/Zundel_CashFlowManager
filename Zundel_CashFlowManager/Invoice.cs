using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zundel_CashFlowManager
{
    class Invoice : IPayable
    {
        private string _partNumber;
        private int _quantity;
        private string _partDescription;
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
        }
        public string PartDescription
        {
            get { return _partDescription; }
        }
        public int Quantity
        {
            get { return _quantity; }
        }
        public string PartNumber
        {
            get { return _partNumber; }
        }
        public Invoice(string PartNumber, string PartDescription, int Quantity, decimal Price)
        {
            _partNumber = PartNumber;
            _partDescription = PartDescription;
            _quantity = Quantity;
            _price = Price;

        }
        public IPayable.LedgerType GetLedgerType()
        {
            return IPayable.LedgerType.Invoice;
        }

        decimal IPayable.GetPayableAmount()
        {
            return Total();
        }

        private int RandomNum()
        {
            Random number = new Random((int)DateTime.Now.Ticks);
            return number.Next(111111, 999999);
        }
        private decimal Total()
        {
            decimal total = Price * Quantity;
            return total;
        }
        public override string ToString()
        {
            return
            "Invoice: " + RandomNum() +"_"+PartNumber+
            "\nQuantity: " + Quantity +
            "\nPart Description: " + PartDescription +
            "\nUnit Price: " + Price +
            "\nExtended Price: " + Total();
        }



    }
}
