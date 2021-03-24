using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoDivibank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDivibank.DAO
{
    public class LoanController : Controller
    {
        private readonly LoanContext _context;

        public LoanController(LoanContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CreatePedido([Bind("idPedido,dtPedido,vlPedido,idCliente")] Loan loan)
        {
            //loan.Loans.
            using (var clientContext = new ClientController(new ClientContext()))
            {
                if (clientContext.ClientExists(loan.idCliente))
                {
                    if (ModelState.IsValid)
                    {
                        _context.Add(loan);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }                    
                }
            }
            return View(loan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPedido(long id, [Bind("idPedido,dtPedido,vlPedido,idCliente")] Loan loan)
        {
            if (id != loan.idPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanExists(loan.idPedido))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(loan);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var loan = await _context.Loans.FindAsync(id);
            _context.Loans.Remove(loan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanExists(long id)
        {
            return _context.Loans.Any(e => e.idPedido == id);
        }


        public async Task<IActionResult> BuscarPedidos()
        {
            return View(await _context.Loans.ToListAsync());
        }


        // GET: Home/Details/5
        public async Task<IActionResult> BuscarPedido(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Loans
                .FirstOrDefaultAsync(m => m.idPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
    }
}
