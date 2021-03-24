using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDivibank.Models
{
    [Table("tb_Clientes")]
    public class Client
    {
        [Key]
        public long idCliente { get; set; }
        public DateTime birthdateCliente { get; set; }
        public string nomeCliente { get; set; }
        
    }

    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public ClientContext(DbContextOptions<ClientContext> options) :
            base(options)
        {
        }

        public ClientContext()
        {

        }
    }
}
