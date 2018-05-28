using BankingSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSolution.Repository
{
    public interface ITransactionRepository
    {
        Transaction GetTransactionByTransID(long trans_id);
        List<Transaction> GetTransactionsByAccountNo(long acc_no);
    }
}
