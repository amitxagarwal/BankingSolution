using BankingSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingSolution.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private BankDBContext _transDBContext;
        public TransactionRepository(BankDBContext dbContext) => _transDBContext = dbContext;

        public BankDBContext TransDBContext { get => _transDBContext; set => _transDBContext = value; }

        public Transaction GetTransactionByTransID(long trans_id) =>_transDBContext.transDBSet.Include("Account").FirstOrDefault(x => x.Trans_ID == trans_id);

        public List<Transaction> GetTransactionsByAccountNo(long acc_no) => _transDBContext.transDBSet.Include("Account").ToList().FindAll(x => x.Account_No == acc_no);
    }
}