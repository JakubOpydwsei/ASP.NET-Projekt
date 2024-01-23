using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("cars")]
    public class CarEntity
    {
        [Key]
        [Column("id")]
        public int CarId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [MaxLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        public double EngineCapacity { get; set; }

        [Required]
        public int Power { get; set; }

        [Required]
        public string RegistrationNumber { get; set; }

        [Required]
        public string Owner { get; set; }

    }
}
