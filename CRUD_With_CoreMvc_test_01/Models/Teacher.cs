using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRUD_With_CoreMvc_test_01.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Please Input valid Name")]
        [StringLength(100)]
        [Display(Name="Name")]
        public string Name { get; set; }
        public string Department { get; set; }
        public School School { get; set; }

    }
}
