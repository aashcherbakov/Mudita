using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Mudita.Controllers
{
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {
        // GET api/values
        [HttpGet]
        public Dashboard Get()
        {
            /*
             * For you header
             * 
             * 1
             * a new standard
             * sustained peak performance 
             * 
             * 2. nutrition guide
             * TB12 nutrition philosophy
             * 
             * 3. the weakly workout
             * focus of the day
             * 
             * 4. workout essentials 
             * Gear up
             * 
             * 5. Recipe of the day
             * Black bean burger
             */
            return new Dashboard();
        }
        
    }

    public class Dashboard
    {
        public string Title = "For you";

        public Card[] Cards =
        {
            new Card {Title = "A new standard", Message = "Sustained peak performance"},
            new Card {Title = "Nutrition guide", Message = "TB12 nutrition philosophy"},
            new Card {Title = "The weakly workout", Message = "Focus of the day"},
            new Card {Title = "Workout essentials", Message = "Gear up"},
            new Card {Title = "Recipe of the day", Message = "Black bean burger"},
        };
        
    }

    public class Card
    {
        public string Title;
        public string Message;
    }
}