namespace Domain.Entities;

public class Instructor : BaseEntity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }

    public Instructor ()
    {
        Id = default;
        FirstName = string.Empty;
        LastName = string.Empty;
        FullName = string.Empty;
        CreatedDate = default;
        UpdatedDate = default;
    }

    public Instructor (int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        FullName = $"{firstName.ToLower()}{lastName.ToLower()}";
    }

    public Instructor (int id, string firstName, string lastName, string fullName, DateTime createdDate, DateTime updatedDate)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        FullName = fullName != string.Empty ? fullName : $"{firstName.Split(" ")[0].ToLower()}{lastName.ToLower()}";
        CreatedDate = createdDate;
        UpdatedDate = updatedDate;
    }
}