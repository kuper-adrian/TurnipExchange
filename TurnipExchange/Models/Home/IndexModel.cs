using System.Collections.Generic;
using TurnipExchange.Data;

namespace TurnipExchange.Models.Home
{
	public class IndexViewModel
	{
		public SaleOffer MyOffer { get; set; }
		public ICollection<SaleOffer> AvailableOffers { get; set; }

		public int PageNumber { get; set; }
		public bool HasPreviousPage { get; set; }
		public bool HasNextPage { get; set; }
	}
}