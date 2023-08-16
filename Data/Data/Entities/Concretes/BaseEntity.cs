using System;
using System.ComponentModel.DataAnnotations;
using Data.Entities.Interfaces;

namespace Data.Entities.Concretes
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.UtcNow;
    }
}

