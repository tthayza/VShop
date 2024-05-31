﻿using AutoMapper;
using VShop.CartApi.Models;
using VShopCartApi.Models;

namespace VShop.CartApi.DTOs.Mappings;

public class MappingProfile : Profile
{

    public MappingProfile()
    {
        CreateMap<CartDTO, Cart>().ReverseMap();
        CreateMap<CartHeaderDTO, CartHeader>().ReverseMap();
        CreateMap<CartItemDTO, CartItem>().ReverseMap();
        CreateMap<ProductDTO, Product>().ReverseMap();
    }
}
