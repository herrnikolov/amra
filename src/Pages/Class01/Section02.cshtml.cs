using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HamRadioLicense.Pages.Class01
{
    public class Section02Model : PageModel
    {
        public List<Question> Section02 = new List<Question>();
        public void OnGet()
        {
            var jsonString = System.IO.File.ReadAllText(@"wwwroot/seedfiles/class02_section02_codes_abbriviations.json");
            Section02 = JsonSerializer.Deserialize<List<Question>>(jsonString);
        }
    }
}