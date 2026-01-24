using System;
using AutoMapper;
using NetCleanArchMvc.Application.DTOs;
using NetCleanArchMvc.Application.Products.Commands;

namespace NetCleanArchMvc.Application.Mappings;

public class DTOToCommandMappingProfile : Profile
{
    public DTOToCommandMappingProfile()
    {
        CreateMap<ProductDTO, ProductCreateCommand>();
        CreateMap<ProductDTO, ProductUpdateCommand>();
    }
}
