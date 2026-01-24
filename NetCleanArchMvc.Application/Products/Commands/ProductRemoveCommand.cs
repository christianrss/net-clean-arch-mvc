using MediatR;
using NetCleanArchMvc.Domain.Entities;

namespace NetCleanArchMvc.Application.Products.Commands;

public class ProductRemoveCommand : IRequest<Product>
{
    public int Id { get; set; }
    public ProductRemoveCommand(int id)
    {
        Id = id;
    }
}
