using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WWW1.Models;

namespace WWW1.Pages
{
    public class OstatnieModel : PageModel
    {
        public Czas Czas { get; set; }
        public void OnGet()
        {
            var SessionAddress =
HttpContext.Session.GetString("Historia");

            if (SessionAddress != null)
                Czas = JsonConvert.DeserializeObject<Czas>(SessionAddress);
        }
    }
}