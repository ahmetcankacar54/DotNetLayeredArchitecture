using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities.Concretes
{
	public class Category : BaseEntity 
	{
        public required string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

