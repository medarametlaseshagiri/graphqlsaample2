using GraphQLSample.Context.Data;
using GraphQLSample.Repository.Interfaces;

namespace GraphQLSample.Repository
{
    public class SHPViewDlogWithAuditRepository : ISHPViewDlogWithAuditRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public SHPViewDlogWithAuditRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
