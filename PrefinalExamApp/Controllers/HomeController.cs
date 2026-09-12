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
questions.Add(new ExamQuestion {
    Number = 11,
    QuestionText = "Why use a ViewModel instead of passing EF Core entities directly to a View?",
    Options = new List<string> { "A. Entities cannot be rendered in HTML", "B. To combine or shape the data specifically needed by the view", "C. To speed up database performance", "D. ViewModel replaces the Controller layer" },
    CorrectAnswer = "B. To combine or shape the data specifically needed by the view",
    Explanation = "ViewModels decouple UI display requirements from domain entity structures."
});
questions.Add(new ExamQuestion {
    Number = 12,
    QuestionText = "What happens when eager loading is applied to a navigation property in EF Core?",
    Options = new List<string> { "A. It loads the related Section navigation property", "B. It defers loading until accessed", "C. It executes separate SQL queries for each item", "D. It clears the cache" },
    CorrectAnswer = "A. It loads the related Section navigation property",
    Explanation = "Eager loading includes related data in the initial database query execution."
});
questions.Add(new ExamQuestion {
    Number = 13,
    QuestionText = "Which type of validation runs in the user's web browser before submitting a form?",
    Options = new List<string> { "A. Server-side validation", "B. Client-side validation", "C. Database validation", "D. Middleware validation" },
    CorrectAnswer = "B. Client-side validation",
    Explanation = "Client-side validation provides instant feedback using JavaScript/HTML5 prior to request dispatch."
});
questions.Add(new ExamQuestion {
    Number = 14,
    QuestionText = "Why is server-side validation strictly necessary even if client-side validation is implemented?",
    Options = new List<string> { "A. Client-side validation can be bypassed", "B. Server-side validation is faster", "C. Browsers do not support validation", "D. Server validation replaces models" },
    CorrectAnswer = "A. Client-side validation can be bypassed",
    Explanation = "Users can disable JavaScript or craft malicious direct HTTP requests, bypassing client logic."
});
questions.Add(new ExamQuestion {
    Number = 15,
    QuestionText = "Which field attribute in a Student domain model requires custom logic or database constraints to enforce uniqueness?",
    Options = new List<string> { "A. First Name", "B. Student Number should be unique", "C. Enrolled Date", "D. Section ID" },
    CorrectAnswer = "B. Student Number should be unique",
    Explanation = "Unique constraints prevent duplicate business identifiers like Student Numbers."
});
questions.Add(new ExamQuestion {
    Number = 16,
    QuestionText = "What benefit do database constraints (e.g., UNIQUE, FOREIGN KEY) provide?",
    Options = new List<string> { "A. It protects data integrity even if application-level validation is bypassed", "B. Improves application startup time", "C. Automatically generates views", "D. Eliminates controller logic" },
    CorrectAnswer = "A. It protects data integrity even if application-level validation is bypassed",
    Explanation = "Database-level constraints serve as the ultimate defense for data consistency."
});
questions.Add(new ExamQuestion {
    Number = 17,
    QuestionText = "What is the primary reason to use try-catch blocks when saving changes to a database?",
    Options = new List<string> { "A. To suppress all runtime errors automatically", "B. To catch and handle exceptions that may occur during execution", "C. To speed up execution", "D. Required by EF Core syntax" },
    CorrectAnswer = "B. To catch and handle exceptions that may occur during execution",
    Explanation = "Try-catch blocks catch database operation exceptions gracefully and allow custom recovery logic."
});
questions.Add(new ExamQuestion {
    Number = 18,
    QuestionText = "Which ASP.NET Core middleware configures a custom user-friendly error page for production environments?",
    Options = new List<string> { "A. UseDeveloperExceptionPage()", "B. UseExceptionHandler()", "C. UseRouting()", "D. UseDatabaseErrorPage()" },
    CorrectAnswer = "B. UseExceptionHandler()",
    Explanation = "UseExceptionHandler catches unhandled exceptions and redirects users to a production error view."
});
questions.Add(new ExamQuestion {
    Number = 19,
    QuestionText = "How should an application handle an attempt to access a record ID that does not exist?",
    Options = new List<string> { "A. Throw an unhandled NullReferenceException", "B. Display a Not Found (404) response/page", "C. Redirect to login", "D. Automatically create a blank record" },
    CorrectAnswer = "B. Display a Not Found (404) response/page",
    Explanation = "Returning NotFound() signals to the client that the requested resource identifier does not exist."
});
            return View(questions);
        }
    }
}