using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Mudita.Controllers
{

    [Route("api/[controller]")]
    public class EquipmentsController : Controller
    {
        [HttpGet]
        public Dictionary<string, string>[] Get()
        {
            var dictionaries = new List<Dictionary<string, string>>
            {
                new Dictionary<string, string>
                {
                    ["id"] = "124",
                    ["title"] = "Sheathed resistance bands",
                    ["imageUrlPath"] =
                    "https://68.media.tumblr.com/f23aeb4aef2fd9de04a5ff589a20b7d0/tumblr_o8k5maYQLr1tjukx2o2_250.jpg"
                },
                new Dictionary<string, string>
                {
                    ["id"] = "2435",
                    ["title"] = "Continuous Looped Bands",
                    ["imageUrlPath"] =
                    "https://68.media.tumblr.com/d26314ab932bef741c38fd772dee64a9/tumblr_oe26f8JLrE1tjukx2o3_540.jpg"
                },
                new Dictionary<string, string>
                {
                    ["id"] = "3456",
                    ["title"] = "Exercise Ball",
                    ["imageUrlPath"] =
                    "https://68.media.tumblr.com/067f9504deb1fe224c3ffa97b549da0b/tumblr_oj622btrvL1uoz5lzo2_400.jpg"
                },
                new Dictionary<string, string>
                {
                    ["id"] = "3457",
                    ["title"] = "Medicine ball",
                    ["imageUrlPath"] =
                    "https://68.media.tumblr.com/3970b1c9550508aa34e9639be0c4f70c/tumblr_o8mtwgfFwK1tcb9uto2_540.jpg"
                },
                new Dictionary<string, string>
                {
                    ["id"] = "7345",
                    ["title"] = "Kettlebell",
                    ["imageUrlPath"] =
                    "https://68.media.tumblr.com/3970b1c9550508aa34e9639be0c4f70c/tumblr_o8mtwgfFwK1tcb9uto2_540.jpg"
                },
                new Dictionary<string, string>
                {
                    ["id"] = "3457354",
                    ["title"] = "Plyo box",
                    ["imageUrlPath"] =
                    "https://68.media.tumblr.com/c3df4593d8c62c00ecf0d8d0966f83e8/tumblr_odyi8urdVU1ujt1dqo1_1280.jpg"
                }
            };
            return dictionaries.ToArray();
        }
    }
}