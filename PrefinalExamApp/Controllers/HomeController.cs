using Microsoft.AspNetCore.Mvc;
using PrefinalExamApp.Models;

namespace PrefinalExamApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = new List<ExamQuestion>();

            questions.Add(new ExamQuestion {
    Number = 1,
    QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
    Options = new List<string> {
        "A. It makes C# code shorter",
        "B. It prevents the application from restarting",
        "C. It allows data to persist after the application stops",
        "D. It removes the need for MVC"
    },
    CorrectAnswer = "C. It allows data to persist after the application stops",
    Explanation = "Databases provide non-volatile storage, preserving data across restarts."
});
            return View(questions);
        }
    }
}