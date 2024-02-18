using Domain.Entities;

namespace Application.CategortServices;

public interface ICategoryService
{
    List<Category> GetAll ();
    Category GetById (int id);


    string Add (Category category);
    string Update (Category category);
    string Delete (int id);
}