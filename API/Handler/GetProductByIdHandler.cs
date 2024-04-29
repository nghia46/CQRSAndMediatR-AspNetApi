using API;
using MediatR;

public class GetProductByIdHandler(FakeDataStore fakeDataStore) : IRequestHandler<GetProductByIdQuery, Product>
{
    private readonly FakeDataStore _fakedataStore = fakeDataStore;

    public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return await _fakedataStore.GetProductById(request.Id);
    }
}