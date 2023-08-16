using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities.Interfaces
{
	public interface IBaseEntity
	{
        
        public int Id { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}

