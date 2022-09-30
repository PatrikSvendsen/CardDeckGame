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

    /// <summary>
    /// API-controller som tar emot en request från clienten och skickar den vidare till Service-lagret.
    /// </summary>
    /// <returns>Returnerar data om det finns annars null i värde.</returns>
    [HttpGet]
    public async Task<IActionResult> GetHistorys()
    {
        var historys =
            await _service.HistoryService.GetAllHistoryASync(trackChanges: false);
        return Ok(historys);
    }

    /// <summary>
    /// API-controller som tar emot en request från clienten och skickar den vidare till Service-lagret.
    /// </summary>
    /// <param name="id">Id på den entitet man vill hämta</param>
    /// <returns>Returnerar data om det finns annars null i värde.</returns>
    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetHistory(int id)
    {
        var history =
            await _service.HistoryService.GetHistoryAsync(id, trackChanges: false);
        return Ok(history);
    }

    /// <summary>
    /// API-controller som tar emot en request från clienten och skickar den vidare till Service-lagret.
    /// </summary>
    /// <param name="history">Den entitet man vill skapa</param>
    /// <returns>Returnerar en entitet med nytt Id om det lyckats skapas i databasen.</returns>
    [HttpPost]
    public async Task<IActionResult> CreateHistory([FromBody] HistoryForCreationDto history)
    {
        if (history is null)  
            return BadRequest("HistoryForCreation object is null");

        var createdHistory = 
            await _service.HistoryService.CreateHistoryAsync(history);
        return CreatedAtRoute(new { id = createdHistory.Id }, createdHistory);
    }   
}
