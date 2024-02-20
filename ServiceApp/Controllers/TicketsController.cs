using ServiceApp.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceApp.Interfaces;

namespace ServiceApp.Controllers
{
    public class TicketsController : Controller
    {

        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        public IActionResult Index()
        {
            return View(_ticketService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Ticket ticket = new Ticket();
            return View(ticket);
        }

        [HttpPost]
        public IActionResult Create(Ticket model)
        {
            if (ModelState.IsValid)
            {
                _ticketService.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
