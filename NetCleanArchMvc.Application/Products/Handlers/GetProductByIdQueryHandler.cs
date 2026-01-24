using MediatR;
using NetCleanArchMvc.Application.Products.Queries;
using NetCleanArchMvc.Domain.Entities;
using NetCleanArchMvc.Domain.Interfaces;

namespace NetCleanArchMvc.Application.Products.Handlers;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    public readonly IProductRepository _productRepository;

    public GetProductByIdQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> Handle(GetProductByIdQuery request,
        CancellationToken cancellationToken)
    {
        return await _productRepository.GetByIdAsync(request.Id);
    }
}
