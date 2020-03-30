using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TurnipExchange.Data;
using TurnipExchange.Models;

namespace TurnipExchange.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;

		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			SaleOffer myOffer = null;

			if (User.Identity.IsAuthenticated)
			{
				myOffer = await _context
					.Users
					.Where(u => u.UserName == User.Identity.Name)
					.Select(u => u.SaleOffer)
					.FirstOrDefaultAsync();
			}

			var offers = await _context
				.SaleOffer
				.Include(s => s.User)
				.OrderByDescending(s => s.Price)
				.Take(10)
				.ToListAsync();

			return View(new Models.Home.IndexModel
			{
				CurrentOffer = myOffer,
				Top10Offers = offers,
			});
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
