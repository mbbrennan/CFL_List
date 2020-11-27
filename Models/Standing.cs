using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie2.Models
{
    public class Standing
    {
        [Key]
        public int ID { get; set; }
        public string LongName { get; set; }
        public int GP { get; set; }

        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Ties { get; set; }
        public int Points { get; set; }
        public int PointsFor { get; set; }

        public int PointsAgainst { get; set; }
    }
}
