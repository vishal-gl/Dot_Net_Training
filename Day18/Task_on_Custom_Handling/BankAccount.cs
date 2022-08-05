using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_on_Custom_Handling
{
    public class BankAccount
    {
        public string _accountNumber;
        public string _name;
        public  double _balance;
        public string _type;
        public double _transactionAmount;
        public BankAccount()
        {

        }
       
        public string GAccountNumber()
        {
            return this._accountNumber;
        }
        public string GName()
        {
            return this._name;
        }
        public double GBalance()
        {
            return _balance;
        }
        public string GType()
        {
            return this._type;
        }
        public double GTransactionAmount()
        {
            return this._transactionAmount;
        }

    }
}
