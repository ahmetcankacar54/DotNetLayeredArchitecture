using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities.Concretes
{
    public class Brand : BaseEntity
    {
        public required string Name { get; set; }
        public required int Year { get; set; }
        public ICollection<Product> Products { get; set; }
        
    }
}

