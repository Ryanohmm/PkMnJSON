public class Pokemon
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Level { get; set; }
    public string Trainer { get; set; }
    public bool IsEgg { get; set; }
}

public class Daycare
{
    public List<Pokemon> Pokemon { get; set; }
}
