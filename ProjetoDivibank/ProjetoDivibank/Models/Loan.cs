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
        public decimal vlPedido { get; set; }
        public long idCliente { get; set; }
    }
}
