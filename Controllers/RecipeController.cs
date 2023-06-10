using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class Recipes : ControllerBase {

    [HttpGet(Name = "recipe")]
    public IEnumerable<Recipe> Get() {
        using FileStream stream = System.IO.File.OpenRead("./data/recipes.json");
        return JsonSerializer.Deserialize<List<Recipe>>(stream) ?? new List<Recipe>();
    }

    [HttpGet("img/{imageName}")]
    public IActionResult  Get(string imageName) {
        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "data", "img", imageName);
        return PhysicalFile(imagePath, "image/jpeg");
    }
}
