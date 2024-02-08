using Business.Abstract;
using Entities.Concreate;

namespace Business.Concreate;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }

    public bool CheckPerson(Person person)
    {

        return true;
    }

    public List<Person> GetList()
    {
        List<Person> people = new();
        return people;
    }
}