using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Concretes
{
	public class Product : BaseEntity
	{
        public required string Name { get; set; }
        public required int ProductCode { get; set; }
        public required double Price { get; set; }
        public required int Stock { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public required int BrandId { get; set; }
	}

}

