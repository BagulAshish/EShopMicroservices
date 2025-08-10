using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public class CreateProductEndpoint : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
