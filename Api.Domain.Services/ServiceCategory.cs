using Api.Domain.Core.Interfaces.Repository;
using Api.Domain.Core.Services;
using Api.Domain.Entitys;

namespace Api.Domain.Services
{
    public class ServiceCategory : ServiceBase<Category>, IServiceCategory
    {
        private readonly IRepositoryCategory repositoryCategory;

        public ServiceCategory(IRepositoryCategory _repositoryCategory) : base(_repositoryCategory)
        {
            repositoryCategory = _repositoryCategory;
        }
    }
}
