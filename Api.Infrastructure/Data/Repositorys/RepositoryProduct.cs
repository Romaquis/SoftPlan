using Api.Domain.Core.Interfaces.Repository;
using Api.Domain.Entitys;

namespace Api.Infrastructure.Data.Repositorys
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext sqlContext;
        public RepositoryProduct(SqlContext _sqlContext) : base(_sqlContext)
        {
            this.sqlContext = _sqlContext;
        }
    }
}
