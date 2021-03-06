﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HamRadioLicense.Pages
{
    public class Section03Model : PageModel
    {
        public List<Question> Section03 = new List<Question>();
        public void OnGet()
        {
            var jsonString = System.IO.File.ReadAllText(@"wwwroot/seedfiles/class02_section03_legal_framework.json");
            Section03 = JsonSerializer.Deserialize<List<Question>>(jsonString);
        }
    }
}