using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBO
{
    public class account
    {
        int cusID;
        int amount;
        string accountType;
        DateTime sdate;
        string status;
        string customername;

        public int CusID
        {
            get
            {
                return cusID;
            }

            set
            {
                cusID = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public string AccountType
        {
            get
            {
                return accountType;
            }

            set
            {
                accountType = value;
            }
        }

        public DateTime Sdate
        {
            get
            {
                return sdate;
            }

            set
            {
                sdate = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Customername
        {
            get
            {
                return customername;
            }

            set
            {
                customername = value;
            }
        }

        public account(int cusID, int amount, string accountType, DateTime sdate, string status)
        {
            this.cusID = cusID;
            this.amount = amount;
            this.accountType = accountType;
            this.sdate = sdate;
            this.status = status;
        }
        public account() { }
    }
}
