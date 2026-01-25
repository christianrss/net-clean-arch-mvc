using MediatR;
using NetCleanArchMvc.Domain.Entities;

namespace NetCleanArchMvc.Application.Products.Queries;

public class GetProductByIdQuery : IRequest<Product>
{
    public int Id { get; set; }
    public GetProductByIdQuery(int id)
    {
        Id = id;
    }
}
