using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects.History;

namespace CardDeckGame.Presentation.Controllers;

[Route("api/historys")]
[ApiController]
public class HistorysController : ControllerBase
{
    private readonly IServiceManager _service;
    public HistorysController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetHistorys()
    {
        var historys =
            await _service.HistoryService.GetAllHistoryASync(trackChanges: false);
        return Ok(historys);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetHistory(int id)
    {
        var history =
            await _service.HistoryService.GetHistoryAsync(id, trackChanges: false);
        return Ok(history);
    }

    [HttpPost]
    public async Task<IActionResult> CreateHistory(HistoryForCreationDto history) //[FromBody] 
    {
        if (history is null)  
            return BadRequest("HistoryForCreation object is null");

        var createdHistory = 
            await _service.HistoryService.CreateHistoryAsync(history);
        return CreatedAtRoute(new { id = createdHistory.Id }, createdHistory);
    }   
}
