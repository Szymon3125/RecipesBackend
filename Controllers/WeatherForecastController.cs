using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class Recipes : ControllerBase {

    [HttpGet(Name = "Recipe")]
    public IEnumerable<Recipe> Get() {
        using FileStream stream = System.IO.File.OpenRead("./data/recipes.json");
        return JsonSerializer.Deserialize<List<Recipe>>(stream) ?? new List<Recipe>();
    }
}
