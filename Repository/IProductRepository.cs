using System;
using microservices_rabbit.Data.ValueObjects;

namespace microservices_rabbit.Repository
{
    public interface IProductRepository

    {
        Task<IEnumerable<ProductDTO>> FindAll();
        Task<ProductDTO> FindById(int id);
        Task<ProductDTO> Create(ProductDTO product);
        Task<ProductDTO> Update(ProductDTO product);
        Task<Boolean> Delete(int id);
    }
}

