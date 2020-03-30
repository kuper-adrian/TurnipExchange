using System.Collections.Generic;

namespace TurnipExchange.Data
{
	public class SaleOffer : BaseEntity
	{
		public int Price { get; set; }

		public string UserId { get; set; }
		public User User { get; set; }

		public ICollection<InterestedParty> InterestedParties { get; set; }
	}
}