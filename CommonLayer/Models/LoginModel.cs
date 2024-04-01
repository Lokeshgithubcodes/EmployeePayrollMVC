using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "ID CANNOT BE EMPTY....")]
        [RegularExpression(@"[0-9]", ErrorMessage = "ID MUST BE A NUMBER")]
        public int Id { get; set; }

        [Required(ErrorMessage = "NAME CANNOT BE EMPTY....")]
        public string Name { get; set; }

    }
}
