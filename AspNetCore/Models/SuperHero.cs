using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class SuperHero
    {
        [Key]
        public string name { get; set; }
        public string alterEgo { get; set; }
        public string secondarySuperheroAbility { get; set; }
        public string catchphrase { get; set; }
     
    }
}
