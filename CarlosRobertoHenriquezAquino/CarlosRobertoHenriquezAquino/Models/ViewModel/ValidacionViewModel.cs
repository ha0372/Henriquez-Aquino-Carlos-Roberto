using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarlosRobertoHenriquezAquino.Models.ViewModel
{
    public class ValidacionViewModel
    {

        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Campo obligatorio")]
        public int Monto { get; set; }

    }
}