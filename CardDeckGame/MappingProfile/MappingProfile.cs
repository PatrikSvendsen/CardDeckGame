using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects.CardDeck;

namespace CardDeckGame.MappingProfile;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CardDeck, CardDeckDto>();
    }
}
