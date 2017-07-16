using Microsoft.AspNetCore.Mvc;

namespace Mudita.Controllers
{
    public class FocusesController : Controller
    {
        [HttpGet]
        public WorkoutFocus[] Get()
        {
            return new[]
            {
                new WorkoutFocus("1", "Weekend worrior", "https://68.media.tumblr.com/61e2383bfeaff9426bf8e270b05e738f/tumblr_ol2oiisRCu1tjz73xo1_1280.jpg"),
                new WorkoutFocus("1", "Cross-training", "https://68.media.tumblr.com/3234487d71a1428d237c4425949b52ef/tumblr_oj622btrvL1uoz5lzo1_400.jpg"),
                new WorkoutFocus("1", "Basketball", "https://68.media.tumblr.com/067f9504deb1fe224c3ffa97b549da0b/tumblr_oj622btrvL1uoz5lzo2_400.jpg"),
                new WorkoutFocus("1", "Football", "https://68.media.tumblr.com/e4f584e7d27f8b5d203e3bbf43b9f169/tumblr_oj622btrvL1uoz5lzo6_400.jpg"),
                new WorkoutFocus("1", "Softball", "https://68.media.tumblr.com/dbe02cbb215d936542551cf004965466/tumblr_oj622btrvL1uoz5lzo5_400.jpg"),
                new WorkoutFocus("1", "Baseball", "https://68.media.tumblr.com/99fad15aa32af0b2505dc0efe2ae728b/tumblr_oj988p4tWw1r2br17o1_540.png"),
                new WorkoutFocus("1", "Hockey", "https://68.media.tumblr.com/d26314ab932bef741c38fd772dee64a9/tumblr_oe26f8JLrE1tjukx2o3_540.jpg"),
                new WorkoutFocus("1", "Soccer", "https://68.media.tumblr.com/f23aeb4aef2fd9de04a5ff589a20b7d0/tumblr_o8k5maYQLr1tjukx2o2_250.jpg"),
                new WorkoutFocus("1", "Football (QB)", "https://68.media.tumblr.com/3970b1c9550508aa34e9639be0c4f70c/tumblr_o8mtwgfFwK1tcb9uto2_540.jpg"),
                new WorkoutFocus("1", "Programming", "https://68.media.tumblr.com/c3df4593d8c62c00ecf0d8d0966f83e8/tumblr_odyi8urdVU1ujt1dqo1_1280.jpg"),
            };
        }
    }
    
    
    /// <summary>
    /// Object that describes workout focus - ex: Football Quaterback.
    /// </summary>
    public class WorkoutFocus
    {
        public readonly string Id;
        public readonly string Name;
        public readonly string ImageUrlPath;

        public WorkoutFocus(string id, string name, string imageUrlPath)
        {
            Id = id;
            Name = name;
            ImageUrlPath = imageUrlPath;
        }
    }
}