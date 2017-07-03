using Microsoft.AspNetCore.Mvc;

namespace Mudita.Controllers
{
    [Route("api/[controller]")]
    public class LibraryController : Controller
    {
        // GET api/values
        [HttpGet]
        public Library Get()
        {
            return FakeLibrary();
        }

        private Library FakeLibrary()
        {
            var methodBasics = new Genre("Method Basics", new[]
            {
                new Course("Intro to the TB12 method", false),
                new Course("Pliability 101", true),
                new Course("Exercise 101", true),
                new Course("Nutrition 101", true),
                new Course("Form Basics", false),
                new Course("Resistance Bands 101", false)
            });

            var nutritionBasics = new Genre("Nutrition Basics", new[]
            {
                new Course("Nutrition Philosophy", false),
                new Course("Kitchen Techniques", true),
                new Course("Recipe Book", true),
                new Course("Performance Meals", false)
            });

            return new Library(new[] {methodBasics, nutritionBasics});
        }
    }


    public class Library
    {
        public readonly Genre[] Genres;

        public Library(Genre[] genres)
        {
            Genres = genres;
        }
    }

    public class Genre
    {
        public readonly Course[] Courses;
        public readonly string Title;

        public Genre(string title, Course[] courses)
        {
            Title = title;
            Courses = courses;
        }
    }

    public class Course
    {
        public string Name;
        public bool IsPremium;
        public int TotalArticles = 1;

        public Course(string name, bool primary)
        {
            Name = name;
            IsPremium = primary;
        }
    }
}