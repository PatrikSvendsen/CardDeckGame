using Microsoft.AspNetCore.Components;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.History;

namespace CardDeckGame.Client.Pages;

public partial class CardHistory
{
    public List<HistoryDto> HistoryList { get; set; } = new List<HistoryDto>();
    [Parameter]
    public CardDto Card { get; set; }

    protected override async Task OnInitializedAsync()
    {
        HistoryList = await HistoryHttpRepository.GetHistorys();
    }
}
