using AutoMapper;
using Contracts;
using MassTransit;
using SearchService.Models;

namespace SearchService;

public class MappingProfiles : Profile
{
   
    public MappingProfiles()
    {
        CreateMap<AuctionCreated, Item>();
        CreateMap<AuctionUpdated, Item>();
    }
}
