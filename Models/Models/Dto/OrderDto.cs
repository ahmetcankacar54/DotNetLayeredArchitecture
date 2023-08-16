using System;
using Data.Entities.Concretes;

namespace Models.Dto
{
	public class OrderDto : BaseDto
	{
        public required int OrderNumber { get; set; }
        public required string Adress { get; set; }
        public required int ProductId { get; set; }
        public required int UserId { get; set; }
    }
	public class OrderUpdateDto : BaseDto
	{
		public required int Id { get; set; }
		public required int OrderNumber { get; set; }
		public required string Adress { get; set; }
		public required int ProductId { get; set; }
		public required int UserId { get; set; }
	}
}


