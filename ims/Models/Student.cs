using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ims.Models
{
    public class Student
    {

        public int Id { get; set; }

        public string Password { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(10, 20)]
        public int Age { get; set; }


        public Gender Gender { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        
    }
}