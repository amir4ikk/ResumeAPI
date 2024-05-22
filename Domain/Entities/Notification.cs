namespace Domain.Entities;
public class Notification : BaseEntity
{
    public Review Review { get; set; } = new();
    public int ReviewId { get; set; }
}
