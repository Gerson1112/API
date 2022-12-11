using NetCore6.Model.Context;
using NetCore6.Model.Entities;

namespace NetCore6.Model.Repositories
{
    public interface ITurismoRepository : IBaseRepository<Turismo> { }

    public class TurismoRepository : BaseRepository<Turismo>, ITurismoRepository
    {
        public TurismoRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}