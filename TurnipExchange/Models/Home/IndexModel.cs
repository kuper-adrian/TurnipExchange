using System.Collections.Generic;
using TurnipExchange.Data;

namespace TurnipExchange.Models.Home
{
	public class IndexModel
	{
		public SaleOffer CurrentOffer { get; set; }
		public ICollection<SaleOffer> Top10Offers { get; set; } = new List<SaleOffer>();
	}
}