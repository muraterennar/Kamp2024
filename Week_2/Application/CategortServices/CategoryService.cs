using Domain.Entities;
using Persistence.Repositories.CategoryRepository;

namespace Application.CategortServices;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService (ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public List<Category> GetAll ()
    {
        return _categoryRepository.GetAll();
    }

    public Category GetById (int id)
    {
        if (id == null)
            throw new Exception("İd Boş Olamaz");
        return _categoryRepository.GetById(id);
    }

    public string Add (Category category)
    {
        if (category == null)
            return "Eklemede Hata Oluştu";

        _categoryRepository.Add(category);
        return "Başarıyla Eklendi";
    }

    public string Delete (int id)
    {
        if (id == null)
            return "Silmede Hata Oldu";
        _categoryRepository.Delete(id);
        return "Başarıyla Silme";
    }

    public string Update (Category category)
    {
        if (category == null)
            return "Güncellemede Hata Oluştu";
        _categoryRepository.Updated(category);

        return "Başarıyla Güncellendi";
    }
}