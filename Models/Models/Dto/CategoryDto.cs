using System;
using Data.Entities.Concretes;

namespace Models.Dto
{
	public class CategoryDto : BaseDto
	{
		public required string Name { get; set; }
	}
	public class CategoryUpdateDto : BaseDto
	{
		public required int Id { get; set; }
		public required string Name { get; set; }
	}
}

