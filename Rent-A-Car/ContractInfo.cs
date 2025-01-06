using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car
{
    public class ContractInfo
    {
        public string contractStartDate;
        public string contractEndDate;
        public string price;
        public string deposit;
        public int contractNumber;
        public string branch;
        public string? employeeName;

        public ContractInfo(string contractStartDate, string contractEndDate, string price, 
                            string deposit, int contractNumer, string branch, string employeeName) 
        {
            this.contractStartDate = contractStartDate;
            this.contractEndDate = contractEndDate;
            this.price = price;
            this.deposit = deposit;
            this.contractNumber = contractNumer;
            this.branch = branch;
            this.employeeName = employeeName;
        }

        public ContractInfo(string contractStartDate, string contractEndDate, string price, string deposit, int contractNumer)
        {
            this.contractStartDate= contractStartDate;
            this.contractEndDate= contractEndDate;
            this.price = price;
            this.deposit = deposit;
            this.contractNumber = contractNumer;
        }
    }
}
