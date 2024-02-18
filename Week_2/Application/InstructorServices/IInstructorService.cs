using Domain.Entities;

namespace Application.InstructorServices;

public interface IInstructorService
{
    List<Instructor> GetAll ();
    Instructor GetById (int id);

    string Add (Instructor instructor);
    string Update (Instructor instructor);
    string Delete (int id);
}