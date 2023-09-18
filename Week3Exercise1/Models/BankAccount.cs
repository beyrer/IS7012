﻿using System.ComponentModel;

namespace Week3Exercise1.Models
{
    public class BankAccount
    {
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }
        [DisplayName("Current Balance")]
        public decimal CurrentBalance { get; set; }
        [DisplayName("Account Name")]
        public string AccountName { get; set; }
        public int Id { get; set; }
        public AccountHolder? AccountHolder { get; set; }
        [DisplayName("Account Holder Name")]
        public int AccountHolderId { get; set; }
        public decimal PriorBalance { get; set; }
        public string AccountType { get; set; }

    }
}
