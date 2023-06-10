namespace backend;

public class Recipe {
    public int RecipeID { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public String[] Ingredients { get; set; }
    public int[] Steps { get; set; }
    public String image { get; set; }
}
