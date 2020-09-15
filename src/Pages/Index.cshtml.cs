using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HamRadioLicense.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
    public class Question
    {
        [JsonPropertyName("problem")]
        public string Problem { get; set; }
        
        [JsonPropertyName("correct")]
        public string CorrectAnswer { get; set; }
        
        [JsonPropertyName("a")]
        public string AnswerA { get; set; }
        
        [JsonPropertyName("b")]
        public string AnswerB { get; set; }
        
        [JsonPropertyName("c")]
        public string AnswerC { get; set; }

        [JsonPropertyName("d")]
        public string AnswerD { get; set; }

        public Question()
        {

        }
        public Question(string problem, string answerA, string answerB, string answerC, string answerD, string correctAnswer)
        {
            problem = Problem;
            answerA = AnswerA;
            answerB = AnswerB;
            answerC = AnswerC;
            answerD = AnswerD;
            correctAnswer = CorrectAnswer;
        }
    }
}
