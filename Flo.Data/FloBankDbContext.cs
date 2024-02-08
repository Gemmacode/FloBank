using FloBank.Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FloBank.Data
{
    public class FloBankDbContext : DbContext
    {
        public FloBankDbContext(DbContextOptions<FloBankDbContext> options) : base(options)
        {

        }
        public  DbSet<Account> Accounts { get; set; }   
        public DbSet<Transaction> Transactions { get; set; }    
    }
}
