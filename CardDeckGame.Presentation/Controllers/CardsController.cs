using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CardDeckGame.Presentation.Controllers;

[Route("api/cardDecks/{cardDeckId}/cards")]
[ApiController]
public class CardsController : ControllerBase
{
    private readonly IServiceManager _service;
    public CardsController(IServiceManager service) => _service = service;


    [HttpGet]
    public async Task<IActionResult> GetCardsFromCardDeck(int cardDeckId)
    {
        var cards = 
            await _service.CardService.GetCardsAsync(cardDeckId, trackChanges: false);
        return Ok(cards);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCardFromCardDeck(int cardDeckId, int id)
    {
        var card = 
            await _service.CardService.GetCardAsync(cardDeckId, id, trackChanges: false);
        return Ok(card);
    }
}
