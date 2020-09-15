using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HamRadioLicense.Pages
{
    public class Section01Model : PageModel
    {
        public List<Question> Section01 = new List<Question>();
        public void OnGet()
        {
            var jsonString = System.IO.File.ReadAllText(@"wwwroot/seedfiles/class02_section01_electrotechnics_and_radiotechnics.json");
            Section01 = JsonSerializer.Deserialize<List<Question>>(jsonString);
        }
    }
}