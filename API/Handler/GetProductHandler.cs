using API.Queries;
using MediatR;

namespace API.Handler
{
    public class GetProductHandler(FakeDataStore fakeDataStore) : IRequestHandler<GetProductQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore _dataStore = fakeDataStore;

        public async Task<IEnumerable<Product>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _dataStore.GetProducts();
        }
    }
}
