using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WWW1.Models
{
    public class Czas
    {

        [Range(1, 1000, ErrorMessage = "Podano złe dane")]
        public int Number { get; set; }
        public string St { get; set; }
       
            public DateTime Dataa { get; set; }

    }




}

