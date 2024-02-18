namespace Domain.Entities;

public class Course : BaseEntity<int>
{
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public int InstructorId { get; set; }
    public int CategoryId { get; set; }

    public Course ()
    {
        Id = default;
        CourseName = string.Empty;
        CourseDescription = string.Empty;
        InstructorId = default;
        CategoryId = default;
        CreatedDate = default;
        UpdatedDate = default;
    }

    public Course (int id, string courseName, string courseDescription, int instructor, int categoryId, DateTime createdDate, DateTime updtedDate)
    {
        Id = id;
        CourseName = courseName;
        CourseDescription = courseDescription;
        InstructorId = instructor;
        CategoryId = categoryId;
        CreatedDate = createdDate;
        UpdatedDate = updtedDate;
    }
}