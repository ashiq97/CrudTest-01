using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD_With_CoreMvc_test_01.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }

        [Required]
        [Display(Name="School Name")]
        public string Name { get; set; }
        
        [Required]
        public string Location { get; set; }
        public List<Teacher> Teachers { get; set; }

    }
}
