using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.CardDeck;

namespace CardDeckGame.Presentation.Controllers;

[Route("api/cardDecks")]
[ApiController]
public class CardDecksController : ControllerBase
{
    private readonly IServiceManager _service;

    public CardDecksController(IServiceManager service)
    {
        _service = service;
    }


    [HttpGet]
    public async Task<IActionResult> GetCardDecks()
    {
        var cardDecks =
            await _service.CardDeckService.GetAllCardDecksAsync(trackChanges: false);
        return Ok(cardDecks);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetCardDeckById(int id)
    {
        var cardDeck =
            await _service.CardDeckService.GetCardDeckByIdAsync(id, trackChanges: false);
        return Ok(cardDeck);
    }

    private static async Task<IEnumerable<CardDeckDto>> GetTestCardDeck()
    {
        var cardDecks = new List<CardDeckDto>();
        cardDecks.Add(new CardDeckDto()
        {
            Id = 1,
            Name = "JackOfAllTrades",
            TotalCards = 52,
            Cards = new List<CardDto>()
            {
                new CardDto
                {
                    Id = 1,
                    Name = "Test"
                }
            }
        });

        return cardDecks;
    }

}
