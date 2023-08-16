using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Concretes
{
	public class Order : BaseEntity
	{
        public required int OrderNumber { get; set; }
        public required string Adress { get; set; }
		public required int UserId { get; set; }
		public required int ProductId { get; set; }
	

	}
}

