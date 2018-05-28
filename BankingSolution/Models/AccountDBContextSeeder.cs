using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BankingSolution.Models
{
    public class AccountDBContextSeeder: DropCreateDatabaseIfModelChanges<BankDBContext>
    {
        protected override void Seed(BankDBContext context)
        {
            Account account1 = new Account()
            {
                Cust_First_Name = "Amit",
                Cust_Last_Name = "Agarwal",
                Cust_AccountType = Account.AccounType.Savings,
                Cust_Account_Balance = 10000,
                Transactions = new List<Transaction>()
                {
                   new Transaction()
                   {
                       Trans_Type = Transaction.Transaction_Type.Credit,
                       Trans_DateTime = DateTime.Now.AddDays(-10),
                       Trans_Amount = 10000
                   },
                   new Transaction()
                   {
                       Trans_Type = Transaction.Transaction_Type.Debit,
                       Trans_DateTime = DateTime.Now.AddDays(-5),
                       Trans_Amount = 10000
                   },
                   new Transaction()
                   {
                       Trans_Type = Transaction.Transaction_Type.Credit,
                       Trans_DateTime = DateTime.Now.AddDays(-2),
                       Trans_Amount = 10000
                   }
                }

            };

          
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Account', RESEED,100000);");
            base.Seed(context);
        }

    }
}