using System;

namespace TurnipExchange.Data
{
	public class BaseEntity
	{
		public long Id { get; set; }

		public DateTime Created { get; set; }
	}
}