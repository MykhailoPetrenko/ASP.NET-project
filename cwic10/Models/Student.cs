using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cwic10.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }
        [RegularExpression(@"s[0-9]{5}",ErrorMessage ="Cos")]
        [StringLength(6)]
        [Required]
        public string NrIndeksu { get; set; }

    }
}
