using Business.Abstract;
using Entities.Concreate;

namespace Business.Concreate;

public class PttManager : ISupplierService
{
    private readonly IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }

    public void GetGive(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine($"{person.FisrtName} için maske verildi.");
        }
    }
}