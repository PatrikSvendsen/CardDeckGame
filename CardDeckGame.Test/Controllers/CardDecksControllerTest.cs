using CardDeckGame.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Service.Contracts;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.CardDeck;

namespace CardDeckGame.Test.Controllers;

public class CardDecksControllerTest
{
    private readonly Mock<IServiceManager> _mockService;
    public CardDecksControllerTest()
    {
        _mockService = new Mock<IServiceManager>();
    }

    // Testar att hämta all historik och kollar så det är rätt typ och status som kommer tillbaka
    [Fact]
    public void GetAllCardDeckAsync_ListOfCardDeckDto_CardDeckExistInRepo()
    {
        // Arrange
        var cardDecks = GetTestCardDecks();
        _mockService.Setup(x => x.CardDeckService.GetAllCardDecksAsync(false))
            .Returns(GetTestCardDecks());

        var controller = new CardDecksController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetCardDecks();
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.IsType<List<CardDeckDto>>(actual);
    }

    // Testar att hämta all historik och kontrollerar så det är rätt status och entitet som kommer tillbaka
    [Fact]
    public void GetCardDeckByIdAsync_OkObjectResultAndCardDeckDto_CardDeckExistInRepo()
    {
        // Arrange
        var cardDeck = GetTestCardDeckById();

        _mockService.Setup(x => x.CardDeckService.GetCardDeckByIdAsync(1, It.IsAny<bool>()))
            .Returns(cardDeck);

        var controller = new CardDecksController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetCardDeckById(1);
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.IsType<CardDeckDto>(actual);
        Assert.Equal(cardDeck.Result, actual);
    }

    // Kontrollerar så att om en entiet inte existerar skall den skicka tillbaka OKObjectResult och Null i värde på retur.
    [Fact]
    public void GetCardDeckByIdAsync_OKObjectResultAndNullInValue_CardDeckWithIdDoesNotExistInRepo()
    {
        //Arrange
        var cardDeck = GetTestCardDeckById();

        _mockService.Setup(x => x.CardDeckService.GetCardDeckByIdAsync(1, It.IsAny<bool>()))
            .Returns(cardDeck);

        var controller = new CardDecksController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetCardDeckById(2);
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.Null(actual);
    }

    // Här nedan finns endast skitkod för att skapa "listor" med carddecks.
    #region List of CardDecks
    private static async Task<IEnumerable<CardDeckDto>> GetTestCardDecks()
    {
        var cardDecks = new List<CardDeckDto>();
        cardDecks.Add(new CardDeckDto()
        {
            Id = 1,
            Name = "JackOfAllTrades",
            TotalCards = 52,
            Cards = new List<CardDto>()
            {
                new CardDto
                {
                    Id = 1,
                    Name = "Test"
                }
            }
        });

        return cardDecks;
    }

    private static async Task<CardDeckDto> GetTestCardDeckById()
    {
        var cardDeck = new CardDeckDto
        {
            Id = 1,
            Name = "JackOfAllTrades",
            TotalCards = 52,
            Cards = new List<CardDto>()
            {
                new CardDto
                {
                    Id = 1,
                    Name = "Test"
                }
            }
        };

        return cardDeck;
    }
    #endregion
}
