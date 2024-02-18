using Domain.Entities;

namespace Persistence.Repositories.CourseRepository;

public class CourseRepository : BaseRepository<Course, int>, ICourseRepository
{
    public CourseRepository (List<Course> entities) : base(entities)
    {
        List<Course> courses = new List<Course>()
        {
            new Course()
            {
                Id = 1,
                CategoryId = 1,
                InstructorId = 1,
                CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
                CourseDescription = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz."
            },

            new Course()
            {
                Id = 2,
                CategoryId = 2,
                InstructorId = 1,
                CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
                CourseDescription = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz."
            },

            new Course()
            {
                Id = 3,
                CategoryId = 3,
                InstructorId = 2,
                CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
                CourseDescription = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz."
            }
        };

        entities.AddRange(courses);
    }
}