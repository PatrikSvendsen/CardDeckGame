using CardDeckGame.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Service.Contracts;
using Shared.DataTransferObjects.Card;

namespace CardDeckGame.Test;

public class CardsControllerTest
{
    private readonly Mock<IServiceManager> _mockService;
    public CardsControllerTest()
    {
        _mockService = new Mock<IServiceManager>();
    }

    [Fact]
    public void GetCardsAsync_ListOfCardsDto_CardsExistInRepo()
    {
        // Arrange
        var cards = GetListOfCardDto_Test();
        _mockService.Setup(x => x.CardService.GetCardsAsync(1, It.IsAny<bool>()))
            .Returns(GetListOfCardDto_Test);

        var controller = new CardsController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetCardsFromCardDeck(1);
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.IsType<List<CardDto>>(actual);
    }

    [Fact]
    public void GetCardByIdAsync_OkObjectResultAndCardDto_CardWithIdExistInRepo()
    {
        // Arrange
        var card = GetCardDtoById_Test();

        _mockService.Setup(x => x.CardService.GetCardAsync(1, 1, It.IsAny<bool>()))
            .Returns(card);

        var controller = new CardsController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetCardFromCardDeck(1, 1);
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        //Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.IsType<CardDto>(actual);
    }

    [Fact]
    public void GetCardByIdAsync_OkObjectResultAndNullCardDto_CardWithIdDoesNotExistInRepo()
    {
        // Arrange
        var card
            = GetCardDtoById_Test();

        _mockService.Setup(x => x.CardService.GetCardAsync(1, 1, It.IsAny<bool>()))
            .Returns(card);

        var controller = new CardsController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetCardFromCardDeck(1, 2);
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.Null(actual);
    }

    // Här nedan finns endast skitkod för att skapa "listor" med cards.
    #region List of Cards

    private static async Task<CardDto> GetCardDtoById_Test()
    {
        var card = new CardDto
        {
            Id = 1,
            Name = "Ace of Hearts",
            Suit = "Hearts",
            CardDeckId = 1,
            ImgName = "/images/hearts/ace.png"
        };

        return card;
    }

    private static async Task<IEnumerable<CardDto>> GetListOfCardDto_Test()
    {
        var cards = new List<CardDto> {
            new CardDto
            {
                Id = 1,
                Name = "Ace of Hearts",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/ace.png"
            },
            new CardDto
            {
                Id = 2,
                Name = "Two",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/2.png"
            },
            new CardDto
            {
                Id = 3,
                Name = "Three",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/3.png"
            },
            new CardDto
            {
                Id = 4,
                Name = "Four",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/4.png"
            },
            new CardDto
            {
                Id = 5,
                Name = "Five",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/5.png"
            },
            new CardDto
            {
                Id = 6,
                Name = "Six",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/6.png"
            },
            new CardDto
            {
                Id = 7,
                Name = "Seven",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/7.png"
            },
            new CardDto
            {
                Id = 8,
                Name = "Eight",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/8.png"
            },
            new CardDto
            {
                Id = 9,
                Name = "Nine",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/9.png"
            },
            new CardDto
            {
                Id = 10,
                Name = "Ten",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/10.png"
            },
            new CardDto
            {
                Id = 11,
                Name = "Jack",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/jack.png"
            },
            new CardDto
            {
                Id = 12,
                Name = "Queen",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/queen.png"
            },
            new CardDto
            {
                Id = 13,
                Name = "King",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/king.png"
            },
            new CardDto
            {
                Id = 14,
                Name = "Ace of Clubs",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/ace.png"
            },
            new CardDto
            {
                Id = 15,
                Name = "Two",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/2.png"
            },
            new CardDto
            {
                Id = 16,
                Name = "Three",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/3.png"
            },
            new CardDto
            {
                Id = 17,
                Name = "Four",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/4.png"
            },
            new CardDto
            {
                Id = 18,
                Name = "Five",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/5.png"
            },
            new CardDto
            {
                Id = 19,
                Name = "Six",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/6.png"
            },
            new CardDto
            {
                Id = 20,
                Name = "Seven",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/7.png"
            },
            new CardDto
            {
                Id = 21,
                Name = "Eight",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/8.png"
            },
            new CardDto
            {
                Id = 22,
                Name = "Nine",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/9.png"
            },
            new CardDto
            {
                Id = 23,
                Name = "Ten",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/10.png"
            },
            new CardDto
            {
                Id = 24,
                Name = "Jack",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/jack.png"
            },
            new CardDto
            {
                Id = 25,
                Name = "Queen",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/queen.png"
            },
            new CardDto
            {
                Id = 26,
                Name = "King",
                Suit = "Clubs",
                CardDeckId = 1,
                ImgName = "/images/clubs/king.png"
            },
            new CardDto
            {
                Id = 27,
                Name = "Ace of Spades",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/ace.png"
            },
            new CardDto
            {
                Id = 28,
                Name = "Two",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/2.png"
            },
            new CardDto
            {
                Id = 29,
                Name = "Three",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/3.png"
            },
            new CardDto
            {
                Id = 30,
                Name = "Four",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/4.png"
            },
            new CardDto
            {
                Id = 31,
                Name = "Five",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/5.png"
            },
            new CardDto
            {
                Id = 32,
                Name = "Six",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/6.png"
            },
            new CardDto
            {
                Id = 33,
                Name = "Seven",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/7.png"
            },
            new CardDto
            {
                Id = 34,
                Name = "Eight",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/8.png"
            },
            new CardDto
            {
                Id = 35,
                Name = "Nine",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/9.png"
            },
            new CardDto
            {
                Id = 36,
                Name = "Ten",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/10.png"
            },
            new CardDto
            {
                Id = 37,
                Name = "Jack",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/jack.png"
            },
            new CardDto
            {
                Id = 38,
                Name = "Queen",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/queen.png"
            },
            new CardDto
            {
                Id = 39,
                Name = "King",
                Suit = "Spades",
                CardDeckId = 1,
                ImgName = "/images/spades/king.png"
            },
            new CardDto
            {
                Id = 40,
                Name = "Ace of Diamonds",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/ace.png"
            },
            new CardDto
            {
                Id = 41,
                Name = "Two",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/2.png"
            },
            new CardDto
            {
                Id = 42,
                Name = "Three",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/3.png"
            },
            new CardDto
            {
                Id = 43,
                Name = "Four",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/4.png"
            },
            new CardDto
            {
                Id = 44,
                Name = "Five",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/5.png"
            },
            new CardDto
            {
                Id = 45,
                Name = "Six",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/6.png"
            },
            new CardDto
            {
                Id = 46,
                Name = "Seven",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/7.png"
            },
            new CardDto
            {
                Id = 47,
                Name = "Eight",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/8.png"
            },
            new CardDto
            {
                Id = 48,
                Name = "Nine",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/9.png"
            },
            new CardDto
            {
                Id = 49,
                Name = "Ten",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/10.png"
            },
            new CardDto
            {
                Id = 50,
                Name = "Jack",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/jack.png"
            },
            new CardDto
            {
                Id = 51,
                Name = "Queen",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/queen.png"
            },
            new CardDto
            {
                Id = 52,
                Name = "King",
                Suit = "Diamonds",
                CardDeckId = 1,
                ImgName = "/images/diamonds/king.png"
            }};

        return cards;
    }
    #endregion
}
