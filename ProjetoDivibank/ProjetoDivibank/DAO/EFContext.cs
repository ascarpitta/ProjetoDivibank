using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDivibank.Models;

namespace ProjetoDivibank.DAO
{
    public class EFContext : DbContext
    {
        public EFContext() { }
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
