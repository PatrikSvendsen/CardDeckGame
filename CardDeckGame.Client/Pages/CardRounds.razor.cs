using CardDeckGame.Client.HttpRepository.CardDeckHttp;
using Microsoft.AspNetCore.Components;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.CardDeck;

namespace CardDeckGame.Client.Pages;

public partial class CardRounds
{
    public CardDeckDto CardDeck { get; set; }
    [Parameter]
    public CardDto Card { get; set; }


    protected override async Task OnInitializedAsync()
    {
        CardDeck = await CardDeckHttpRepository.GetCardDeck(1);
    }
}
