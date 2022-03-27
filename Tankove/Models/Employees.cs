using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Tankove.Models
{
    public class Employees
    {
        //table - employees
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("first name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("last name")]
        public string LastName { get; set; }
        [Required]
        [Range(0,int.MaxValue, ErrorMessage ="The number of months experience must be positive")]
        [DisplayName("experience")]
        public int Experience { get; set; }
        [Required]
        public string Position { get; set; }
    }
}
