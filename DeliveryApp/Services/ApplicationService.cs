using Domain.Interfaces;

namespace API
{
    public partial class ApplicationService : IApplicationService
    {
        private readonly IOrderDomainRepository _orderDomainRepository;
        private readonly IProductDomainRepository _productDomainRepository;
        private readonly IUserDomainRepository _userDomainRepository;

        public ApplicationService(IOrderDomainRepository orderDomainRepository, IProductDomainRepository productDomainRepository, IUserDomainRepository userDomainRepository) { 
            this._orderDomainRepository = orderDomainRepository;
            this._productDomainRepository = productDomainRepository;
            this._userDomainRepository = userDomainRepository;
        }
    }
}
