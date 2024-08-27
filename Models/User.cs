using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CimenogluCourse.Models
{
    public class User
    {
        [Required(ErrorMessage = "İsim belirtmez zorunludur")]
        [StringLength(15, ErrorMessage = "İsim max. 15 karakter olabilir.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim belirtmez zorunludur")]
        [StringLength(15, ErrorMessage = "Soyisim max. 25 karakter olabilir.")]

        public string? LastName { get; set; }

        [Required(ErrorMessage = "Yaş belirtmez zorunludur")]
        [Range(18, 65, ErrorMessage = "Üye olabilmek için 18-65 yaş aralığında olmalısınız.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Eposta belirtmez zorunludur")]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Mail formatı hatalı")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Şifre belirtmez zorunludur")]
        [MinLength(6, ErrorMessage = "En az 6 karakter olmalı")]
        [MaxLength(10, ErrorMessage = "Maksimum 10 karakter olmalıdır")]
        public string? Password { get; set; }
    }

    public class RegisterUsers : List<User>
    {

    }
}

