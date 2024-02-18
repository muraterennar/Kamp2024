using Domain.Entities;

namespace Persistence.Repositories;

public interface IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
{
    List<TEntity> GetAll ();
    TEntity GetById (TId id);

    void Add (TEntity entity);
    void Updated (TEntity entity);
    void Delete (TId id);
}
