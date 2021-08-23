using Api.Domain.Core.Interfaces.Repository;
using Api.Domain.Entitys;

namespace Api.Infrastructure.Data.Repositorys
{
    public class RepositoryCategory : RepositoryBase<Category>, IRepositoryCategory
    {
        private readonly SqlContext sqlContext;
        public RepositoryCategory(SqlContext _sqlContext): base(_sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
