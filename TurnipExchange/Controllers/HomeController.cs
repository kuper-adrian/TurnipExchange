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
using TurnipExchange.Models.Home;

namespace TurnipExchange.Controllers
{
	public class HomeController : Controller
	{
		private const int PAGE_SIZE = 25;

		private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext _context;

		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}


		public async Task<IActionResult> Index([FromQuery]int page = 0)
		{
			var now = DateTime.Now.ToUniversalTime();

			var myOffer = await _context
					.Users
					.Where(u => u.UserName == User.Identity.Name)
					.SelectMany(u => u.SaleOffers)
					.OrderByDescending(so => so.Created)
					.FirstOrDefaultAsync();

			var availableOffersQuery = _context
				.SaleOffer
				.Where(so => so.Expires > now && so.IsActive)
				.OrderByDescending(so => so.Price);

			var total = await availableOffersQuery.CountAsync();
			var availableOffers = await availableOffersQuery
				.Skip(page * PAGE_SIZE)
				.Take(PAGE_SIZE)
				.Include(so => so.User)
				.ToListAsync();

			return View(new IndexViewModel
			{
				MyOffer = myOffer,
				AvailableOffers = availableOffers,
				PageNumber = page,
				HasPreviousPage = page > 0,
				HasNextPage = page * PAGE_SIZE + PAGE_SIZE < total,
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
