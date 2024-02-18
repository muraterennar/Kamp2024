namespace Domain.Entities;

public class Category : BaseEntity<int>
{
    public string CategoryName { get; set; }
    public Category ()
    {
        CategoryName = string.Empty;
        CreatedDate = default;
        UpdatedDate = default;
    }

    public Category (int id, string categoryName)
    {
        CategoryName = categoryName;
    }

    public Category (int id, string categoryName, DateTime createdDate, DateTime updatedDate)
    {
        Id = id;
        CategoryName = categoryName;
        CreatedDate = createdDate;
        UpdatedDate = updatedDate;
    }
}