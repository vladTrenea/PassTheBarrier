﻿namespace PassTheBarier.Core.Data.Entities
{
	public class Barrier: Entity
	{
		public int CountryPrefixId { get; set; }

		public string Number { get; set; }

		public string MessageText { get; set; }
	}
}