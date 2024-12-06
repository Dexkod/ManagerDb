namespace Db;

public class Cars : BaseEntity
{
    public int Price { get; set; }
    public string Name { get; set; }
    public int Power { get; set; }
    public string Color { get; set; }
    public int? UserId { get; set; }
}
