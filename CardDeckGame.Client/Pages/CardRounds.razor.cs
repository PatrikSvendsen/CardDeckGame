using Microsoft.AspNetCore.Components;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.CardDeck;
using Shared.DataTransferObjects.History;

namespace CardDeckGame.Client.Pages;

public partial class CardRounds
{
    private CardDeckDto CardDeck { get; set; }
    public List<CardDto> Hand { get; set; }
    private List<CardDto> ShuffledCardDeck { get; set; }
    private List<CardDto> newCardsToAdd { get; set; }

    private int cardsToFill;

    [Parameter]
    public bool clearHand { get; set; } = false;
    private static Random rnd = new Random();

    protected override async Task OnParametersSetAsync()
    {
        CardDeck = await CardDeckHttpRepository.GetCardDeck(1);
    }

    protected async void ShuffleCardDeck(bool check)
    {
        var cardsList = await CardHttpRepository.GetCards(1);
        var n = 52;

        while (n > 1)
        {
            int k = (rnd.Next(0, n) % n);
            n--;
            CardDto value = cardsList[k];
            cardsList[k] = cardsList[n];
            cardsList[n] = value;
        }
        ShuffledCardDeck = cardsList.ToList();
        if (check is true)
        {
            ReShuffle();
        }
        StateHasChanged();
    }

    Task<List<CardDto>> FillHand(int take)
    {
        if (Hand is null)
        {
            Hand = ShuffledCardDeck.Take(take).ToList();
        }
        else
        {
            newCardsToAdd = ShuffledCardDeck.Take(take).ToList();
            foreach (CardDto c in new List<CardDto>(newCardsToAdd))
            {
                Hand.Add(c);
            }
        }

        cardsToFill = 0;
        StateHasChanged();
        return Task.FromResult(Hand);
    }

    public void AddToHistory(List<CardDto> createHistory)
    {
        foreach (var card in Hand)
        {
            if (card.CheckBoxIsActive == true)
            {
                var historyForCreationDto = new HistoryForCreationDto
                {
                    CardId = card.Id
                };
                HistoryHttpRepository.CreateHistory(historyForCreationDto);
            }
        }

        clearHand = true;
    }

    protected void ClearHandOfOldCards()
    {
        cardsToFill = Hand.Where(x => x.CheckBoxIsActive == true).Count();

        foreach (CardDto c in new List<CardDto>(Hand))
        {
            if (c.CheckBoxIsActive == true)
            {
                Hand.Remove(c);
            }
        }
        clearHand = false;
    }

    protected void ClearDeckOfOldCards()
    {
        foreach (var card in Hand)
        {
            ShuffledCardDeck.Remove(card);
        }
    }

    protected void ClearDeck()
    {
        ShuffledCardDeck.Clear();
        StateHasChanged();
    }

    protected void ReShuffle()
    {
        Hand.Clear();
        FillHand(5);
        ClearDeckOfOldCards();
        StateHasChanged();
    }
}
