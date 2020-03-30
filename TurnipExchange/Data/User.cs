using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurnipExchange.Data
{
	public class User : IdentityUser
	{
		public string SwitchAccountName { get; set; }
		public string SwitchFriendCode { get; set; }

		public string AcVillagerName { get; set; }
		public string AcIslandName { get; set; }


		public int Reputation { get; set; }

		public long? TimeZoneId { get; set; }
		public TimeZone TimeZone { get; set; }

		public SaleOffer SaleOffer { get; set; }

		public ICollection<InterestedParty> InterestedIn { get; set; }
	}
}