using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CardDeckGame.Presentation.Controllers;

[Route("api/cardDecks/{cardDeckId}/cards")]
[ApiController]
public class CardsController : ControllerBase
{
    private readonly IServiceManager _service;
    public CardsController(IServiceManager service) => _service = service;

    /// <summary>
    /// API-controller som tar emot en request från clienten och skickar den vidare till Service-lagret.
    /// </summary>
    /// <param name="cardDeckId">Id på den kortlek man vill hämta alla kort från</param>
    /// <returns>Returnerar data om det finns annars null i värde.</returns>
    [HttpGet]
    public async Task<IActionResult> GetCardsFromCardDeck(int cardDeckId)
    {
        var cards = 
            await _service.CardService.GetCardsAsync(cardDeckId, trackChanges: false);
        return Ok(cards);
    }

    /// <summary>
    /// API-controller som tar emot en request från clienten och skickar den vidare till Service-lagret.
    /// </summary>
    /// <param name="cardDeckId">Id på den kortlek man vill hämta alla kort från</param>
    /// <param name="id">Id på den entitet man vill hämta från vald kortlek</param>
    /// <returns>Returnerar data om det finns annars null i värde.</returns>
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCardFromCardDeck(int cardDeckId, int id)
    {
        var card = 
            await _service.CardService.GetCardAsync(cardDeckId, id, trackChanges: false);
        return Ok(card);
    }
}

