using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LoginAndRegister.Pages
{
    public class Register : PageModel
    {
        public Register Model { get; set;}
        public void OnGet()
        {
        }
    }
}
