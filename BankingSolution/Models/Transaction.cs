using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankingSolution.Models
{
    public class Transaction
    {
        public enum Transaction_Type { Debit=1,Credit=2};

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Trans_ID { get; set; }
        public Transaction_Type Trans_Type { get; set; }
        public DateTime Trans_DateTime { get; set; }
        public long Trans_Amount { get; set; }
        public long Account_No { get; set; }

        [ForeignKey("Account_No")]
        public Account Account { get; set; }
    }
}