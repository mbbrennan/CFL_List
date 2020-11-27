using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _27nov2020.Models
{
    public class Team
    {
        [Key]
        public string Abbrev { get; set; }
        public string LongName { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
    }

}
