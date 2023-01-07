using WebApi.Models;

namespace WebApi.Repository.IRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        void Update(Category obj);
        
    }
}
