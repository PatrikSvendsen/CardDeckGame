using CardDeckGame.Client.HttpRepository.CardHttp;
using CardDeckGame.Client.HttpRepository.HistoryHttp;
using Microsoft.AspNetCore.Components;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.History;

namespace CardDeckGame.Client.Pages;

public partial class CardHistory
{
    [Inject]
    public IHistoryHttpRepository HistoryHttpRepository { get; set; }
    [Inject]
    public ICardHttpRepository CardHttpRepository { get; set; }

    public List<HistoryDto> HistoryList { get; set; } = new List<HistoryDto>();

    [Parameter]
    public CardDto Card { get; set; }

    // Hämtar all historik från databasen.
    protected override async Task OnInitializedAsync()
    {
        HistoryList = await HistoryHttpRepository.GetHistorys();
    }
}
