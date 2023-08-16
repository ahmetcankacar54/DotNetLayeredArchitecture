using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities.Concretes
{
	public class User : BaseEntity
	{
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string PhoneNumber { get; set; }

    }
}

