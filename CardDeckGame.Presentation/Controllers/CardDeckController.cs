using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CardDeckGame.Presentation.Controllers;

[Route("api/cardDeck")]
[ApiController]
public class CardDeckController : ControllerBase
{
    private readonly IServiceManager _service;

    public CardDeckController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetCardDecks()
    {
        try
        {
            var cardDecks = _service.CardDeckService.GetAllCardDecks(trackChanges: false);

            return Ok(cardDecks);
        }
        catch (Exception)
        {
            return StatusCode(500, "Internal server error");
        }
    }
}
