using GameToonZombie.Model.Abstract;

namespace GameToonZombie.Data.Abstract
{
    public interface IEntityBaseRepository
    {
        public interface IEntityBaseRepository<T>
    where T : class, IEntityBase, new()
        {
            IEnumerable<T> GetAllZombiePos();
            int Count();
            T GetSingle(int id);
            T GetSingle(string name);
            void Create(T entity);
            void Update(T entity);
            void Delete(T entity);
            void DeleteRange(List<T> entity);
            void Save();
        }
    }
}

