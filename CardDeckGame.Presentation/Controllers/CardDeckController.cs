using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace CardDeckGame.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CardDeckController : ControllerBase
{
    private readonly IServiceManager _service;

    public CardDeckController(IServiceManager service) => _service = service;

    [HttpGet]
    [Route("/cardDecks")]
    [ApiExplorerSettings(GroupName = "v1")]
    public IActionResult GetCardDecks()
    {
        var cardDecks = _service.CardDeckService.GetAllCardDecks(trackChanges: false);
        return Ok(cardDecks);
    }
}
