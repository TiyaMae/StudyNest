using Microsoft.AspNetCore.Mvc;
using StudyNestAPI.Models;

namespace StudyNestAPI.Controllers;

[ApiController]
[Route("api/studyspaces")]
public class StudySpaceController : ControllerBase
{
    [HttpGet]
    public IActionResult GetStudySpaces()
    {
        var spaces = new List<StudySpace>
        {
            new StudySpace
            {
                ID = 1,
                Name = "Coffee Factory",
                Address = "Lahug, Cebu City",
                Latitude = 10.3157,
                Longitude = 123.8854,
                PriceRange = "₱₱",
                Wifi = "Excellent",
                Outlets = "Yes",
                Hours = "8AM - 11PM",
                NoiseLevel = "Quiet",
                Open24Hours = false,
                Rating = 4.8,
                ImageUrl = "coffeefactory.jpg"
            }
        };

        return Ok(spaces);
    }
}