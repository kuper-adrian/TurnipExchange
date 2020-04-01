using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurnipExchange.Data
{
	public class User : IdentityUser
	{
		[PersonalData]
		public string SwitchAccountName { get; set; }
		[PersonalData]
		public string SwitchFriendCode { get; set; }

		[PersonalData]
		public string AcVillagerName { get; set; }
		[PersonalData]
		public string AcIslandName { get; set; }

		[PersonalData]
		public int Reputation { get; set; }

		public long? TimeZoneId { get; set; }
		public TimeZone TimeZone { get; set; }

		public ICollection<SaleOffer> SaleOffers { get; set; }
	}
}