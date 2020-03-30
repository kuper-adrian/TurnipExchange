using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurnipExchange.Data;

namespace TurnipExchange.Controllers
{
    [Authorize]
    public class MyOfferController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MyOfferController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var offer = await _context
                .SaleOffer
                .Where(o => o.User.UserName == User.Identity.Name)
                .FirstOrDefaultAsync();

            return View(offer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaleOffer offer)
        {
            var userId = await _context
                .Users
                .Where(u => u.UserName == User.Identity.Name)
                .Select(u => u.Id)
                .FirstOrDefaultAsync();

            offer.UserId = userId;
            offer.Created = DateTime.Now;

            _context.SaleOffer.Add(offer);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(long id)
        {
            var offer = await _context
                .SaleOffer
                .Where(o => o.Id == id)
                .FirstOrDefaultAsync();

            return View(offer);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(SaleOffer offer)
        {
            _context.SaleOffer.Remove(offer);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}