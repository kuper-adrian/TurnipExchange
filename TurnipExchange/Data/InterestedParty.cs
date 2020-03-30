namespace TurnipExchange.Data
{
	public class InterestedParty : BaseEntity
	{
		public string UserId { get; set; }
		public User User { get; set; }

		public long SaleOfferId { get; set; }
		public SaleOffer SaleOffer { get; set; }
	}
}