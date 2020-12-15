using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
       

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3 and 50 charecters.")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Location must be 3 and 50 charecters.")]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {

            //Empty constructor
        }

    }
}
