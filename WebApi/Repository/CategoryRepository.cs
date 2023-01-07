using WebApi.Data;
using WebApi.Models;
using WebApi.Repository.IRepository;

namespace WebApi.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _db;
        public CategoryRepository(ApplicationDBContext db):base(db)
        {
            _db = db;
        }

        

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
