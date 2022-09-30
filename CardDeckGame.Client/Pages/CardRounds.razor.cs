using CardDeckGame.Client.HttpRepository.CardDeckHttp;
using CardDeckGame.Client.HttpRepository.CardHttp;
using CardDeckGame.Client.HttpRepository.HistoryHttp;
using Microsoft.AspNetCore.Components;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.CardDeck;
using Shared.DataTransferObjects.History;

namespace CardDeckGame.Client.Pages;

public partial class CardRounds
{
    [Inject]
    public IHistoryHttpRepository HistoryHttpRepository { get; set; }
    [Inject]
    public ICardHttpRepository CardHttpRepository { get; set; }
    [Inject]
    public ICardDeckHttpRepository CardDeckHttpRepository { get; set; }

    private CardDeckDto CardDeck { get; set; }
    public List<CardDto> Hand { get; set; }
    private List<CardDto> ShuffledCardDeck { get; set; }
    private List<CardDto> newCardsToAdd { get; set; }

    private int cardsToFill;

    [Parameter]
    public bool clearHand { get; set; } = false;
    private static Random rnd = new Random();

    // Hämtar alla kort från en kortlek från databasen samt lägger dem i en lista. 
    protected async void ShuffleCardDeck(bool check)
    {
        var cardsList = await CardHttpRepository.GetCards(1);
        var n = 52;

        while (n > 1)         // Funktionen nedan shufflar om listan
        {
            int k = (rnd.Next(0, n) % n);
            n--;
            CardDto value = cardsList[k];
            cardsList[k] = cardsList[n];
            cardsList[n] = value;
        }

        ShuffledCardDeck = cardsList.ToList(); // Lägger sedan allt i en ny lista så att man inte rör "originalet"
        
        if (check is true)
            ReShuffle();

        StateHasChanged(); // Här säger vi till blazor-komponentet att något har hänt och att den skall uppdatera sig. På det sättet får vi single-page att fungera.
    }

    // Fyller en hand med "take" i antal kort.
    Task<List<CardDto>> FillHand(int take)
    {
        if (Hand is null)
            Hand = ShuffledCardDeck.Take(take).ToList();
        else
        {
            newCardsToAdd = ShuffledCardDeck.Take(take).ToList();
                foreach (CardDto c in new List<CardDto>(newCardsToAdd))
                    Hand.Add(c);
        }

        cardsToFill = 0;
        StateHasChanged();
        return Task.FromResult(Hand);
    }

    // Lägger de valda korten till historiken
    public void AddToHistory(List<CardDto> createHistory)
    {
        foreach (var card in Hand)
            if (card.CheckBoxIsActive == true)
            {
                var historyForCreationDto = new HistoryForCreationDto
                {
                    CardId = card.Id
                };
                HistoryHttpRepository.CreateHistory(historyForCreationDto);
            }

        clearHand = true;
    }

    // Tömmer handen på gamla kort.
    protected void ClearHandOfOldCards()
    {
        cardsToFill = Hand.Where(x => x.CheckBoxIsActive == true).Count();

        foreach (CardDto c in new List<CardDto>(Hand))
            if (c.CheckBoxIsActive == true)
                Hand.Remove(c);

        clearHand = false;
    }

    // Funktion för att tömma den kopierade listan med kort så att inte samma kort dyker upp.
    protected void ClearDeckOfOldCards()
    {
        foreach (var card in Hand)
            ShuffledCardDeck.Remove(card);
    }

    // Funktion för att endast tömma kortleken, mest för test.
    protected void ClearDeck()
    {
        ShuffledCardDeck.Clear();
        StateHasChanged();
    }

    // Idiot-säker funktion för att göra om hela shuffle-historian.
    protected void ReShuffle()
    {
        Hand.Clear();
        FillHand(5);
        ClearDeckOfOldCards();
        StateHasChanged();
    }
}
