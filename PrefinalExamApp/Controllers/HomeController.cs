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
questions.Add(new ExamQuestion {
    Number = 2,
    QuestionText = "Which Entity Framework Core approach creates models from an existing database?",
    Options = new List<string> { "A. Code-First", "B. Database-First", "C. Model-First", "D. Data-First" },
    CorrectAnswer = "B. Database-First",
    Explanation = "Database-First scaffolds entity classes and DbContext directly from an existing database schema."
});
questions.Add(new ExamQuestion {
    Number = 3,
    QuestionText = "What is the primary role of Object-Relational Mapping (ORM)?",
    Options = new List<string> { "A. To compile C# code into SQL", "B. To render HTML views from models", "C. To map objects in code to relational database data", "D. To handle HTTP request routing" },
    CorrectAnswer = "C. To map objects in code to relational database data",
    Explanation = "ORM bridges object-oriented domain models and relational database tables."
});
questions.Add(new ExamQuestion {
    Number = 4,
    QuestionText = "Which base class in EF Core manages database connections and entity tracking?",
    Options = new List<string> { "A. DbContext", "B. Controller", "C. DbSet", "D. ModelBuilder" },
    CorrectAnswer = "A. DbContext",
    Explanation = "DbContext represents a session with the database and provides APIs for querying and saving data."
});
questions.Add(new ExamQuestion {
    Number = 5,
    QuestionText = "What does reverse engineering (scaffolding) do in EF Core?",
    Options = new List<string> { "A. Converts C# models into SQL scripts", "B. Generates controllers from views", "C. Generates EF Core models and a DbContext from an existing database", "D. Deletes outdated database tables" },
    CorrectAnswer = "C. Generates EF Core models and a DbContext from an existing database",
    Explanation = "Scaffolding inspects the database schema and produces entity classes and DbContext configuration."
});
questions.Add(new ExamQuestion {
    Number = 6,
    QuestionText = "Where is the database connection string typically configured in ASP.NET Core?",
    Options = new List<string> { "A. Program.cs", "B. appsettings.json", "C. HomeController.cs", "D. LaunchSettings.json" },
    CorrectAnswer = "B. appsettings.json",
    Explanation = "Configuration settings like connection strings are stored in appsettings.json."
});
questions.Add(new ExamQuestion {
    Number = 7,
    QuestionText = "What type of relationship exists when one Section contains multiple Students?",
    Options = new List<string> { "A. One-to-One", "B. One-to-Many", "C. Many-to-Many", "D. Self-referencing" },
    CorrectAnswer = "B. One-to-Many",
    Explanation = "A parent record (Section) having multiple child records (Students) represents a One-to-Many relationship."
});
questions.Add(new ExamQuestion {
    Number = 8,
    QuestionText = "In a Student entity, what does the SectionId property represent?",
    Options = new List<string> { "A. Primary Key", "B. Foreign key referencing Section", "C. Navigation property", "D. View model property" },
    CorrectAnswer = "B. Foreign key referencing Section",
    Explanation = "SectionId holds the key value linking a Student to its parent Section."
});
questions.Add(new ExamQuestion {
    Number = 9,
    QuestionText = "What is a navigation property in an EF Core entity model?",
    Options = new List<string> { "A. A URL router property", "B. It represents a relationship to another entity", "C. A UI component key", "D. A database column constraint" },
    CorrectAnswer = "B. It represents a relationship to another entity",
    Explanation = "Navigation properties allow traversing relationships between entity classes in code."
});
questions.Add(new ExamQuestion {
    Number = 10,
    QuestionText = "What is the purpose of calling .Include(s => s.Section) in an EF Core query?",
    Options = new List<string> { "A. Filter students by section", "B. Load related Section data together with Students", "C. Delete associated sections", "D. Sort students by section name" },
    CorrectAnswer = "B. Load related Section data together with Students",
    Explanation = "Include triggers eager loading for related navigation properties."
});
            return View(questions);
        }
    }
}