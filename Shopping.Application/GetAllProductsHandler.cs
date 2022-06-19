using MediatR;
using Shopping.Domain;

namespace Shopping.Application
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductQueryRepository _productQueryRepository;

        public GetAllProductsHandler(IProductQueryRepository productQueryRepository)
        {
            this._productQueryRepository = productQueryRepository;
        }

        public Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return _productQueryRepository.GetAllAsync();
        }
    }
}
