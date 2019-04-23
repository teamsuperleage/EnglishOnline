using English.Data.Infrastructure;
using English.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Data.Repositories
{
   
    public interface ILessonRepository : IRepository<Lesson>
    {
        IEnumerable<Lesson> GetAllElement(int id);
    }

    public class LessonRepository : RepositoryBase<Lesson>, ILessonRepository
    {
        public LessonRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Lesson> GetAllElement(int id)
        {
            var result = DbContext.Lessons.Where(x => x.Id_Course.Equals(id.ToString())).ToList();
            return result;
        }
    }
}
