using CardDeckGame.Presentation.Controllers;
using Contracts.ModelContracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RazorEngine.Compilation.ImpromptuInterface;
using Service.Contracts;
using Service.Contracts.ModelServiceContracts;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.CardDeck;
using Xunit.Sdk;
using Assert = Xunit.Assert;

namespace CardDeckGame.Test.Controllers;

public class CardDeckControllerTest
{

    //private readonly Mock<ICardDeckRepository> _mockRepo;
    //public CardDeckControllerTest()
    //{
    //    _mockRepo = new Mock<ICardDeckRepository>();
    //}    

    private readonly Mock<IServiceManager> _mockService;
    public CardDeckControllerTest()
    {
        _mockService = new Mock<IServiceManager>();
    }

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
        var actual = result.Value as List<CardDeckDto>;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.IsType<List<CardDeckDto>>(actual);
    }

    [Fact]
    public void GetCardDeckByIdAsync_OKObjectResultAndNullInValue_CardDeckWithIdDoesNotExist()
    {
        //Arrange
        var cardDeck = GetTestCardDeckById();

        _mockService.Setup(x => x.CardDeckService.GetCardDeckByIdAsync(1, It.IsAny<bool>()))
            .Returns(() => (cardDeck));

        var controller = new CardDecksController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetCardDeckById(2);
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.Null(actual);
    }





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
}
