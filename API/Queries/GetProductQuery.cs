using MediatR;

namespace API.Queries
{
    public record GetProductQuery() : IRequest<IEnumerable<Product>>;
}
