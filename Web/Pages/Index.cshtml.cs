using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Models;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        [HttpGet]
        public void OnGet()
        {
     
        }

        [HttpGet("shortUrl")]
        public void OnGet(string shortUrl)
        {

        }

        [HttpPost]
        public void OnPost()
        {

        }
    }
}
