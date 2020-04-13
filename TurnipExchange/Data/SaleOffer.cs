using System;
using System.ComponentModel.DataAnnotations;

namespace TurnipExchange.Data
{
	public class SaleOffer : BaseEntity
	{
		[Required]
		public int Price { get; set; }
		public bool IsActive { get; set; }

		[Required]
		[MaxLength(5)]
		[MinLength(5)]
		public string DodoCode { get; set; }

		public string UserId { get; set; }
		public User User { get; set; }

		[MaxLength(300)]
		public string Description { get; set; }
	}
}