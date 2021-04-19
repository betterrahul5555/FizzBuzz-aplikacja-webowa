using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WWW1.Models
{
    public class Address
    {
        [Display(Name = "Podaj liczbę")]
        [Range(1,1000,  ErrorMessage ="Podano złe dane" )]
        [Required(ErrorMessage= "Pole jest obowiazkowe")]
        public int Liczba { get; set; }
        public string check()
        {
           
            string result = "";
            if (Liczba % 3 == 0)
                result += "fizz";
            if (Liczba % 5 == 0)
                result += "buzz";
            if (result == "")
            {
                return "Liczba:" + " "+ Liczba.ToString() +" " +"podana przez użytownika nie spełnia kryteriów zadania";
            }

            return result;
        }


    }
}
