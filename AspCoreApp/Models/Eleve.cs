using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApp.Models
{
    public class Eleve
    {
        [Key]
        public string cne { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public string email { get; set; }
        public string filiere { get; set; }
        public string tel { get; set; }
    }
}
