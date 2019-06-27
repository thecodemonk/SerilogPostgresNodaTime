using System;
using System.ComponentModel.DataAnnotations;

namespace SerilogPostgresNodaTime.Models
{
    public class Table1
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public DateTime MyDate { get; set; }
    }
}