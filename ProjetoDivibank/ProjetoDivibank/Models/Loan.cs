using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDivibank.Models
{
    [Table("tb_Pedidos")]
    public class Loan
    {
        [Key]
        public long idPedido { get; set; }
        public DateTime dtPedido { get; set; }
        public float vlPedido { get; set; }
        public long idCliente { get; set; }
    }

    public class LoanContext : DbContext
    {
        public DbSet<Loan> Loans { get; set; }

        public LoanContext(DbContextOptions<LoanContext> options) :
            base(options)
        {
        }

        public LoanContext()
        {

        }
    }
}
