﻿using System;

namespace MangoPay.SDK.Entities.POST
{
	/// <summary>Bank account base class for POST DTO objects.</summary>
	public class BankingAliasPostDTO : EntityPostBase
    {
		/// <summary>The user ID who was credited.</summary>
		public string CreditedUserId { get; set; }

		/// <summary>THe name of the owner of the bank account.</summary>
		public string OwnerName { get; set; }
    }
}
