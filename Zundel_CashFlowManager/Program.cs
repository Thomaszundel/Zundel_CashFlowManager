using System;
// First or Nickname Lastname
// IT112 
// NOTES: Notes the instructor should read
// BEHAVIORS NOT IMPLEMENTED AND WHY: Are there any parts of the assignment 
// you did not complete?
namespace Zundel_CashFlowManager
{
    class Program
    {

        static void Main(string[] args)
        {
            bool keepGoing = true;
            int choice;
            int arrayCounter;
            
            IPayable[] CashFlowPayout = new IPayable[20];
            CashFlowPayout[0] = new SalariedEmployee("jim", "bob","444442223", 1900m);
            CashFlowPayout[1] = new SalariedEmployee("bob", "jim", "444442223", 1800m);
            CashFlowPayout[2] = new SalariedEmployee("timmy", "pink", "444442223", 2000m);
            CashFlowPayout[3] = new HourlyEmployee("robbert", "yellow", "444442223",15.50m,38);
            CashFlowPayout[4] = new HourlyEmployee("bobbert", "green", "444442223", 15.00m, 40);
            CashFlowPayout[5] = new HourlyEmployee("george", "red", "444442223", 16.00m, 42);
            CashFlowPayout[6] = new Invoice("5676", "The Fixer", 3, 63.99m);
            CashFlowPayout[7] = new Invoice("1123", "Tuna Fish", 40, 1.65m);
            CashFlowPayout[8] = new Invoice("1450", "Bath Tub", 1, 2388.99m);

            arrayCounter = 8;
            while (keepGoing)
            {
                PrintMenu();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddInvoice();
                        break;
                    case 2:
                        AddHourlyEmployee();
                        break;
                    case 3:
                        AddSalariedEmployee();
                        break;
                    case 4:
                        decimal total = 0m;
                        decimal hourlyTotal = 0m;
                        decimal salariedTotal = 0m;
                        decimal invoiceTotal = 0m;
                        Console.WriteLine("Weekly Cash Flow Analysis is as follows:");
                        for (int i = 0; CashFlowPayout[i] != null; i++)
                        {
                            Console.WriteLine("\n" + CashFlowPayout[i].ToString());
                            total += CashFlowPayout[i].GetPayableAmount();

                            switch (CashFlowPayout[i].GetLedgerType())
                            {
                                case IPayable.LedgerType.Invoice:
                                    invoiceTotal += CashFlowPayout[i].GetPayableAmount();
                                    break;
                                case IPayable.LedgerType.Salaried:
                                    salariedTotal += CashFlowPayout[i].GetPayableAmount();
                                    break;
                                case IPayable.LedgerType.Hourly:
                                    hourlyTotal += CashFlowPayout[i].GetPayableAmount();
                                    break;
                            }
                        }
                        Console.WriteLine("\nTotal Weekly Payout: " + total +
                                          "\nCategory Breakdown:\nInvoices: " + invoiceTotal +
                                          "\nSalaried Payroll: " + salariedTotal +
                                          "\nHourly Payroll: " + hourlyTotal+"\n");
                        break;
                    case 5:
                        keepGoing = false;
                        break;
                    
                    default:
                        Console.WriteLine("Option not supported");
                        break;
                }
                void PrintMenu()
                {
                    Console.WriteLine("Choose from the following options:");
                    Console.WriteLine("1. Add a Invoice");
                    Console.WriteLine("2. Add a Hourly Employee");
                    Console.WriteLine("3. Add a Salaried Employee");
                    Console.WriteLine("4. Generate a Weekly Report");
                    Console.WriteLine("5. End Program");
                   

                }
                void AddSalariedEmployee()
                {
                    arrayCounter++;
                    string inputFirst;
                    string inputLast;
                    string inputSSN;
                    decimal inputSalary;
                    Console.WriteLine("Enter employees first name:");
                    inputFirst = Console.ReadLine();
                    Console.WriteLine("Enter employees last name:");
                    inputLast= Console.ReadLine();
                    Console.WriteLine("Enter employees SSN:");
                    inputSSN=Console.ReadLine();
                    Console.WriteLine("Enter employees Salary:");
                    inputSalary=decimal.Parse(Console.ReadLine());

                    CashFlowPayout[arrayCounter] = new SalariedEmployee(inputFirst, inputLast, inputSSN, inputSalary);
                }
                void AddHourlyEmployee()
                {
                    arrayCounter++;
                    string inputFirst;
                    string inputLast;
                    string inputSSN;
                    decimal inputWage;
                    int inputHoursWorked;
                    Console.WriteLine("Enter employees first name:");
                    inputFirst = Console.ReadLine();
                    Console.WriteLine("Enter employees last name:");
                    inputLast = Console.ReadLine();
                    Console.WriteLine("Enter employees SSN:");
                    inputSSN = Console.ReadLine();
                    Console.WriteLine("Enter employees Wage:");
                    inputWage = decimal.Parse( Console.ReadLine());
                    Console.WriteLine("Enter employees Hours worked:");
                    inputHoursWorked = int.Parse(Console.ReadLine());

                    CashFlowPayout[arrayCounter] = new HourlyEmployee(inputFirst, inputLast, inputSSN, inputWage,inputHoursWorked);
                }
                void AddInvoice()
                {
                    arrayCounter++;
                    string inputPartNumber;
                    string inputPartDiscription;
                    int inputQuantity;
                    decimal inputUnitPrice;
                    Console.WriteLine("Enter part number:");
                    inputPartNumber = Console.ReadLine();
                    Console.WriteLine("Enter part discription:");
                    inputPartDiscription = Console.ReadLine();
                    Console.WriteLine("Enter quantity:");
                    inputQuantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter unit price:");
                    inputUnitPrice = decimal.Parse( Console.ReadLine());
                    CashFlowPayout[arrayCounter] = new Invoice(inputPartNumber, inputPartDiscription, inputQuantity, inputUnitPrice);
                }
            }
        }
    }
}
