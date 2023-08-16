using System;
using Data.Entities.Concretes;

namespace Models.Dto
{
	public class ProductDto : BaseDto
	{
        public required string Name { get; set; }
        public required int ProductCode { get; set; }
        public required double Price { get; set; }
        public required int Stock { get; set; }
        public required string Description { get; set; }
        
        public int CategoryId { get; set; }
        
        public int BrandId { get; set; }
        
    }

	public class ProductUpdateDto : BaseDto
	{
		public required int Id { get; set; }
		public required string Name { get; set; }
		public required int ProductCode { get; set; }
		public required double Price { get; set; }
		public required int Stock { get; set; }
		public required string Description { get; set; }
        
		public int CategoryId { get; set; }
        
		public int BrandId { get; set; }
	}
}

