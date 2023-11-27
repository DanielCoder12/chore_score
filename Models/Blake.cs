namespace chore_score.Models;

public class Blake
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Boolean IsBlake { get; set; }
    public Boolean HasHat { get; set; }
    public int Legs { get; set; }
    public string Title { get; set; }

    public Blake(int id, string name, bool isBlake, bool hasHat, int legs, string title)
    {
        Id = id;
        Name = name;
        IsBlake = isBlake;
        HasHat = hasHat;
        Legs = legs;
        Title = title;
    }

}