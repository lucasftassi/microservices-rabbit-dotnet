using System;
using AutoMapper;
using microservices_rabbit.Data.ValueObjects;
using microservices_rabbit.model;
using microservices_rabbit.model.Context;
using Microsoft.EntityFrameworkCore;

namespace microservices_rabbit.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly ShoppingCartContext _context;
        private IMapper _mapper;

        public ProductRepository(ShoppingCartContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Create(ProductDTO product)
        {
            Product p = _mapper.Map<Product>(product);
            _context.Products.Add(p);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductDTO>(p);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                Product p = await _context.Products.Where(x => x.Id == id).FirstAsync();

                if(p is null) 
                {
                    return false;
                }

                _context.Products.Remove(p);
                await _context.SaveChangesAsync();
                return true;
            } catch (Exception e)
            {
                return false;
            }
        }

        public async Task<IEnumerable<ProductDTO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task<ProductDTO> FindById(int id)
        {
            Product product = await _context.Products.Where(p => p.Id == id). FirstAsync();
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> Update(ProductDTO product)
        {
            Product p = _mapper.Map<Product>(product);
            _context.Products.Update(p);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductDTO>(p);
        }
    }
}

