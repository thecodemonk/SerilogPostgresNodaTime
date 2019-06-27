using System;
using System.ComponentModel.DataAnnotations;
using NodaTime;

namespace SerilogPostgresNodaTime.Models
{
    public class Table1
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public OffsetDateTime MyDate { get; set; }
    }
}