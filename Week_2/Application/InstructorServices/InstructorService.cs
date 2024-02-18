using Domain.Entities;
using Persistence.Repositories.InstructorRepository;

namespace Application.InstructorServices;

public class InstructorService : IInstructorService
{
    private readonly IInstructorRepository _instructorRepository;

    public InstructorService (IInstructorRepository instructorRepository)
    {
        _instructorRepository = instructorRepository;
    }

    public List<Instructor> GetAll ()
    {
        return _instructorRepository.GetAll();

    }

    public Instructor GetById (int id)
    {
        return _instructorRepository.GetById(id);
    }

    public string Add (Instructor instructor)
    {
        if (instructor == null)
            return "Eklemede Hata Oluştu";
        _instructorRepository.Add(instructor);

        return "Başarıyla Eklendi";
    }

    public string Delete (int id)
    {
        if (id == null)
            return "Silmede Hata Oluştu";

        _instructorRepository.Delete(id);
        return "Başarıyla Silindi";
    }

    public string Update (Instructor instructor)
    {
        if (instructor == null)
            return "Güncellemede Hata Oluştu";

        _instructorRepository.Updated(instructor);
        return "Başarıyla Güncellendi";
    }
}