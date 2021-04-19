using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WWW1.Date;
using WWW1.Models;
using System.Linq;

namespace WWW1.Pages
{
    public class HistoriaModel : PageModel
    {

        FizzContext fizzContext;
        [BindProperty]
        public int ID { get; set; }

        public HistoriaModel(FizzContext fizz)
        {
            fizzContext = fizz;
        }
        public IEnumerable<Czas> historia;
        public void OnGet()
        {
             historia=fizzContext.Czas.Take(10).OrderByDescending(o=>o.Dataa);

        }
        public IActionResult OnPost()//po usunieciu  wraca do get (profesionala wersja)
        {
            fizzContext.Remove(new Czas() { Id = ID });
            fizzContext.SaveChanges();
            
            return RedirectToPage();

        }
    }
}