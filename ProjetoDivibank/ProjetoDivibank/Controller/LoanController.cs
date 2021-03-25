using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDivibank.DAO;
using ProjetoDivibank.Models;

namespace ProjetoDivibank.Controllers
{
    public class LoanController : Controller
    {
        private readonly EFContext _context;

        public LoanController(EFContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Loans/GetLoans")]
        public List<Loan> GetLoans()
        {
            return _context.Loans.ToList();
        }

        [HttpPost("Loans/GetClientLoans")]
        public dynamic GetClientLoans(long idCliente)
        {
            return (from c in _context.Clients.ToList()
                    join p in _context.Loans.ToList() on c.idCliente equals p.idCliente
                    where c.idCliente == idCliente
                    select new
                    {
                        c.nomeCliente,
                        p.dtPedido,
                        p.vlPedido,
                        p.idPedido
                    }).ToList();
        }

        [HttpPost("Loans/GetLoan")]
        public Loan GetLoan(long id)
        {
            var loan = _context.Loans
                .FirstOrDefault(m => m.idPedido == id);
            if (loan == null)
            {
                return new Loan();
            }

            return loan;
        }

        [HttpPost("Loans/AddLoan")]
        public bool Create([Bind("dtPedido,vlPedido,idCliente")] Loan loan)
        {

            using (var clientController = new ClientController(_context))
            {
                if (clientController.ClientExists(loan.idCliente))
                {
                    try
                    {
                        _context.Add(loan);
                        _context.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }

        [HttpPost("Loans/EditLoan")]
        public bool Edit([Bind("idPedido,dtPedido,vlPedido,idCliente")] Loan loan)
        {
            using (var clientController = new ClientController(_context))
            {
                if (clientController.ClientExists(loan.idCliente))
                {
                    try
                    {
                        if (!LoanExists(loan.idPedido))
                        {
                            return false;
                        }
                        _context.Update(loan);
                        _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }

        [HttpPost("Loans/DeleteLoan")]
        public bool Delete(long id)
        {
            try
            {
                if (!LoanExists(id))
                {
                    return false;
                }
                var loan = _context.Loans
                    .FirstOrDefault(m => m.idPedido == id);
                _context.Loans.Remove(loan);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
            return true;
        }

        private bool LoanExists(long id)
        {
            return _context.Loans.Any(e => e.idPedido == id);
        }
    }
}
