﻿using FloBank.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FloBank.Model.Model
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        public int id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string AccountNumberGenerated { get; set; }
        public decimal CurrentAccountBalance { get; set; }  
        public AccountType AccountType { get; set; } 
        public string Email { get; set; }
        public string phoneNumber { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set;}

        public byte[] PinHash { get; set; } 
        public byte[] PinSalt { get; set; }


        Random rand = new Random();
        public Account()
        {
            AccountNumberGenerated = Convert.ToString((long) rand.NextDouble() * 9_000_000_000L + 1_000_000_000L);
            AccountName = $"{FirstName} {LastName}";
        }
        
       

    }
}
