using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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

    /// <summary>
    /// API-controller som tar emot en request från clienten och skickar den vidare till Service-lagret.
    /// </summary>
    /// <returns>Returnerar data om det finns annars null i värde.</returns>
    [HttpGet]
    public async Task<IActionResult> GetCardDecks()
    {
        var cardDecks =
            await _service.CardDeckService.GetAllCardDecksAsync(trackChanges: false);
        return Ok(cardDecks);
    }

    /// <summary>
    /// API-controller som tar emot en request från clienten och skickar den vidare till Service-lagret.
    /// </summary>
    /// <param name="id">Id på den entitet man vill hämta från databasen</param>
    /// <returns>Returnerar data om det finns annars null i värde.</returns>
    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetCardDeckById(int id)
    {
        var cardDeck =
            await _service.CardDeckService.GetCardDeckByIdAsync(id, trackChanges: false);
        return Ok(cardDeck);
    }
}
