using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Tankove.Models
{
    public class Tanks
    {
        //table tanks
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("name")]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Nationality { get; set; }
        public string Manufacturer { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Engine power for a tank must be greater than zero")]
        [DisplayName("engine name")]
        public int EnginePower { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Cannon size for a tank must be greater than zero")]
        [DisplayName("cannon")]
        public int Cannon { get; set; }
    }
}
