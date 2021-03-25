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
    public class ClientController : Controller
    {
        private readonly EFContext _context;

        public ClientController(EFContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Clients/GetClients")]
        public List<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        [HttpPost("Clients/GetClient")]
        public Client GetClient(long id)
        {
            var client = _context.Clients
                .FirstOrDefault(m => m.idCliente == id);
            if (client == null)
            {
                return new Client();
            }

            return client;
        }

        [HttpPost("Clients/AddClient")]
        public bool Create([Bind("birthdateCliente,nomeCliente")] Client client)
        {
            try
            {
                _context.Add(client);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return false;
            }
            return true;
        }

        [HttpPost("Clients/EditClient")]
        public bool Edit([Bind("idCliente,birthdateCliente,nomeCliente")] Client client)
        {
            try
            {
                if (!ClientExists(client.idCliente))
                {
                    return false;
                }
                _context.Update(client);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
            return true;
        }

        [HttpPost("Clients/DeleteClient")]
        public bool Delete(long id)
        {
            try
            {
                if (!ClientExists(id))
                {
                    return false;
                }
                var client = _context.Clients
                    .FirstOrDefault(m => m.idCliente == id);
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
            return true;
        }

        public bool ClientExists(long id)
        {
            return _context.Clients.Any(e => e.idCliente == id);
        }
    }
}
