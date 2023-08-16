using System;

namespace Models.Dto
{
	public class BrandDto : BaseDto
	{
		public required string Name { get; set; }
		public required int Year { get; set; }
	}
	
	public class BrandUpdateDto : BaseDto
	{
		public required int Id { get; set; }
		public required string Name { get; set; }
		public required int Year { get; set; }
	}
}

