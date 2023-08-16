using System;
namespace Models.Dto
{
	public class LoginDto : BaseDto
	{
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}

