using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CardDeckGame.Presentation.Controllers;

[Route("api/cardDecks")]
[ApiController]
public class CardDecksController : ControllerBase
{
    private readonly IServiceManager _service;
    public CardDecksController(IServiceManager service) => _service = service;


    [HttpGet]
    public async Task<IActionResult> GetCardDecks()
    {
        var cardDecks = 
            await _service.CardDeckService.GetAllCardDecksAsync(trackChanges: false);
        return Ok(cardDecks);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetCardDeck(int id)
    {
        var cardDeck = 
            await _service.CardDeckService.GetCardDeckAsync(id, trackChanges: false);
        return Ok(cardDeck);
    }
}
