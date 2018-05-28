using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankingSolution.Models;

namespace BankingSolution.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankDBContext _accDBContext;
        public AccountRepository(BankDBContext dbContext) => _accDBContext = dbContext;
        public Account GetAccountByAccountNo(long acc_no) => _accDBContext.accDBSet.Include("Transactions").FirstOrDefault(x => x.Cust_Account_No == acc_no);

        public List<Account> GetAccountsByName(string name) => _accDBContext.accDBSet.Include("Transactions").ToList<Account>().FindAll(x => (x.Cust_First_Name + x.Cust_Last_Name) == name);
    }
}