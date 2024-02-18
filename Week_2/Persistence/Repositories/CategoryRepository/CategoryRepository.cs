using Domain.Entities;

namespace Persistence.Repositories.CategoryRepository;

public class CategoryRepository : BaseRepository<Category, int>, ICategoryRepository
{
    public CategoryRepository (List<Category> entities) : base(entities)
    {
        List<Category> categories = new List<Category>()
        {
            new Category() { Id = 1, CategoryName = "C#"},
            new Category() { Id = 2, CategoryName = "Python"},
             new Category() { Id = 3, CategoryName = "Java"},
              new Category() { Id = 4, CategoryName = "Javascript"},
        };

        entities.AddRange(categories);
    }
}