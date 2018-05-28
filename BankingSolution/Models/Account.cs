using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankingSolution.Models
{
    public class Account
    {
        public enum AccounType { Savings=1,Current=2,Loan=3}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Cust_Account_Id { get; }
        public string Cust_First_Name { get; set; }
        public string Cust_Last_Name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Cust_Account_No { get; set; }
        public long Cust_Account_Balance { get; set; }
        
        public AccounType Cust_AccountType { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}