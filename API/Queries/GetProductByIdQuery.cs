using MediatR;

namespace API
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}