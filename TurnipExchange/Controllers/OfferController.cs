using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TurnipExchange.Data;

namespace TurnipExchange.Controllers
{
	public class OfferController : Controller
	{
		private readonly ApplicationDbContext _context;

		public OfferController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(SaleOffer offer)
		{
			if (!ModelState.IsValid)
			{
				return View(offer);
			}

			var userId = await _context
				.Users
				.Where(u => u.UserName == User.Identity.Name)
				.Select(u => u.Id)
				.FirstOrDefaultAsync();

			var created = DateTime.Now.ToUniversalTime();
			DateTime expires;

			if (created.Hour < 12)
			{
				expires = new DateTime(created.Year, created.Month, created.Day, 12, 0, 0);
			}
			else
			{
				expires = new DateTime(created.Year, created.Month, created.Day, 22, 0, 0);
			}

			offer.UserId = userId;
			offer.Created = created;
			offer.IsActive = true;
			offer.Expires = expires;

			_context.SaleOffer.Add(offer);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index", "Home");
		}

		public async Task<IActionResult> Edit(long id)
		{
			var offer = await _context
				.SaleOffer
				.Where(o => o.Id == id)
				.FirstOrDefaultAsync();

			return View(offer);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(SaleOffer offer)
		{
			if (!ModelState.IsValid)
			{
				return View(offer);
			}

			_context.Update(offer);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index", "Home");
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

			return RedirectToAction("Index", "Home");
		}
	}
}