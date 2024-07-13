public class BaseBlock
{
    public string Id { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Range { get; set; }
    public bool IsHead { get; set; }
    public LastAttack LastAttack { get; set; }
}

