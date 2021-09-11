using AutoMapper;
using FreeCourse.Services.Order.Application.Dtos;

namespace FreeCourse.Services.Order.Application.Mapping
{
    class CustomMapper : Profile
    {
        public CustomMapper()
        {
            CreateMap<Domain.Order, OrderDto>().ReverseMap();
            CreateMap<Domain.OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<Domain.Address, AddressDto>().ReverseMap();
        }
    }
}
