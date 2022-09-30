using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.CardDeck;
using Shared.DataTransferObjects.History;

namespace CardDeckGame.Server.MappingProfile;

// Används för att skapa "mappningar" som används för Modeller till DTO's
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // CardDeck
        CreateMap<CardDeck, CardDeckDto>();
        // ---------------


        // Card
        CreateMap<Card, CardDto>();
        // ---------------


        // History
        CreateMap<History, HistoryDto>();
        CreateMap<HistoryDto, History>();
        CreateMap<HistoryForCreationDto, History>();
        // ---------------
    }
}
