namespace Domain.Entities;

public class BaseEntity<TId>
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public BaseEntity ()
    {
        Id = default;
        CreatedDate = default;
        UpdatedDate = default;
    }
}