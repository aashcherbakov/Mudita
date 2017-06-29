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
            new Card {Title = "A new standard", Message = "Sustained peak performance", ImageUrlPath = "https://68.media.tumblr.com/61e2383bfeaff9426bf8e270b05e738f/tumblr_ol2oiisRCu1tjz73xo1_1280.jpg"},
            new Card {Title = "Nutrition guide", Message = "TB12 nutrition philosophy", ImageUrlPath = "https://68.media.tumblr.com/2f95911f9a91ab6d7fc1423676c8af5e/tumblr_okxpqaQSBn1tnx2vpo1_1280.jpg"},
            new Card {Title = "The weakly workout", Message = "Focus of the day", ImageUrlPath = "https://68.media.tumblr.com/dc7f95fbfe36f450babcce34e1cdfe13/tumblr_okxrzkQzzS1tjz73xo1_1280.jpg"},
            new Card {Title = "Workout essentials", Message = "Gear up", ImageUrlPath = "https://68.media.tumblr.com/911f059b44f0a0d27fcdc5fede2f5bac/tumblr_okvm6sH7pU1qc623mo1_1280.jpg"},
            new Card {Title = "Recipe of the day", Message = "Black bean burger", ImageUrlPath = "https://68.media.tumblr.com/61e2383bfeaff9426bf8e270b05e738f/tumblr_ol2oiisRCu1tjz73xo1_1280.jpg"},
        };
        
    }

    public class Card
    {
        public string Title;
        public string Message;
        public string ImageUrlPath;
    }
}