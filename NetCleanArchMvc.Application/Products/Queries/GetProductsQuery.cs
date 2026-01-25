using MediatR;
using NetCleanArchMvc.Domain.Entities;

namespace NetCleanArchMvc.Application.Products.Queries;

public class GetProductsQuery : IRequest<IEnumerable<Product>>
{
}
