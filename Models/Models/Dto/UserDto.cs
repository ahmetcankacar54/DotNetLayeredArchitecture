using System;
namespace Models.Dto
{
	public class UserDto : BaseDto
	{
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string PhoneNumber { get; set; }
    }

	public class UserUpdateDto : BaseDto
	{
		public required int Id { get; set; }
		public required string Name { get; set; }
		public required string Email { get; set; }
		public required string Password { get; set; }
		public required string PhoneNumber { get; set; }
	}
}

