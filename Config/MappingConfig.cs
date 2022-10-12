using System;
using AutoMapper;
using microservices_rabbit.Data.ValueObjects;
using microservices_rabbit.model;

namespace microservices_rabbit.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>();
                config.CreateMap<Product, ProductDTO>();
            });
            return mappingConfig;
        }
    }
}

