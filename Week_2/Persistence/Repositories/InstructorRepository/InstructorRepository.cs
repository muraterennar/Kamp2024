using Domain.Entities;

namespace Persistence.Repositories.InstructorRepository;

public class InstructorRepository : BaseRepository<Instructor, int>, IInstructorRepository
{
    public InstructorRepository (List<Instructor> entities) : base(entities)
    {
        List<Instructor> instructors = new List<Instructor>()
        {
            new Instructor(){Id = 1, FirstName = "Engin", LastName = "Demiroğ"},
            new Instructor(){Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı"},
        };

        entities.AddRange(instructors);
    }
}