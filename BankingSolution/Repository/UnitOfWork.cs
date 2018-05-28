using System;
using BankingSolution.Models;

namespace ContosoUniversity.DAL
{
   public class UnitOfWork : IDisposable
   {
      private BankDBContext context = new BankDBContext();
      private GenericRepository<Account> accountRepository;
      private GenericRepository<Transaction> transactionRepository;

      public GenericRepository<Account> AccountRepository
      {
         get
         {

            if (this.accountRepository == null)
            {
               this.accountRepository = new GenericRepository<Account>(context);
            }
            return accountRepository;
         }
      }

      public GenericRepository<Transaction> CourseRepository
      {
         get
         {

            if (this.transactionRepository == null)
            {
               this.transactionRepository = new GenericRepository<Transaction>(context);
            }
            return transactionRepository;
         }
      }

      public void Save()
      {
         context.SaveChanges();
      }

      private bool disposed = false;

      protected virtual void Dispose(bool disposing)
      {
         if (!this.disposed)
         {
            if (disposing)
            {
               context.Dispose();
            }
         }
         this.disposed = true;
      }

      public void Dispose()
      {
         Dispose(true);
         GC.SuppressFinalize(this);
      }
   }
}
