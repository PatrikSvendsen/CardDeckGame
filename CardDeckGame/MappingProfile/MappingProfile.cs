using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.CardDeck;
using Shared.DataTransferObjects.History;

namespace CardDeckGame.Server.MappingProfile;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CardDeck, CardDeckDto>();

        CreateMap<Card, CardDto>();

        CreateMap<History, HistoryDto>();
        CreateMap<HistoryDto, History>();
        CreateMap<HistoryForCreationDto, History>();
    }
}
