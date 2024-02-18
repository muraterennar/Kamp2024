using Domain.Entities;
using Persistence.Repositories.CourseRepository;

namespace Application.CourseServices;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepository;

    public CourseService (ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public List<Course> GetAll ()
    {
        return _courseRepository.GetAll();
    }

    public Course GetById (int id)
    {
        return _courseRepository.GetById(id);
    }

    public string Add (Course course)
    {
        if (course == null)
            return "Eklemede Hata Oluştu";

        _courseRepository.Add(course);

        return "Başarıyla Eklendi";
    }

    public string Delete (int id)
    {
        if (id == null)
            return "Silmede Hata Oluştu";

        _courseRepository.Delete(id);

        return "Başarıyla Silind";
    }

    public string Update (Course course)
    {

        if (course == null)
            return "Güncellemede Hata Oluştu";

        _courseRepository.Updated(course);
        return "Başarıyla Güncellendi";
    }
}