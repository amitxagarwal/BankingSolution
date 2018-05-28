using BankingSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSolution.Repository
{
    public interface IAccountRepository
    {
        Account GetAccountByAccountNo(long acc_no);
        List<Account> GetAccountsByName(string name);
    }
}
