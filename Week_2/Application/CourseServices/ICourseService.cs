using Domain.Entities;

namespace Application.CourseServices;

public interface ICourseService
{
    List<Course> GetAll ();
    Course GetById (int id);

    string Add (Course course);
    string Update (Course course);
    string Delete (int id);
}