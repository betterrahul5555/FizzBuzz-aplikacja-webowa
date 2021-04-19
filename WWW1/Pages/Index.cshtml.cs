using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WWW1.Date;
using WWW1.Models;

namespace WWW1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]

        public Address Address { get; set; }
        public Czas Czas { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public IndexModel(ILogger<IndexModel> logger, FizzContext fizz)
        {
            _logger = logger;
            fizzContext = fizz;
            
        }
        private FizzContext fizzContext;
 public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Historia",
                JsonConvert.SerializeObject(new Czas() { Number = Address.Liczba, St = Address.check() ,Dataa=DateTime.Now }));
                fizzContext.Add(new Czas() { Number = Address.Liczba, St = Address.check(), Dataa = DateTime.Now });
                fizzContext.SaveChanges();
            }
            return Page();
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
       


    }
}
