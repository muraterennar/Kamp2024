using Domain.Entities;

namespace Persistence.Repositories;

public class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
{
    private readonly List<TEntity> _entities;

    public BaseRepository (List<TEntity> entities)
    {
        _entities = entities;
    }

    public List<TEntity> GetAll ()
    {
        return _entities;
    }

    public TEntity GetById (TId id)
    {
        TEntity entity = _entities.FirstOrDefault(e => e.Id.Equals(id));
        return entity;
    }

    public void Add (TEntity entity)
    {
        entity.CreatedDate = DateTime.Now;
        _entities.Add(entity);
    }

    public void Updated (TEntity entity)
    {
        entity.UpdatedDate = DateTime.Now;
        TEntity updatedEntity = GetById(entity.Id);

        int index = _entities.IndexOf(updatedEntity);
        _entities[index] = entity;
    }

    public void Delete (TId id)
    {
        TEntity deletedEntity = GetById(id);
        _entities.Remove(deletedEntity);
    }
}