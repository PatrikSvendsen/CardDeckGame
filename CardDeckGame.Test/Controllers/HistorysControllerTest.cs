using CardDeckGame.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Service.Contracts;
using Shared.DataTransferObjects.Card;
using Shared.DataTransferObjects.History;

namespace CardDeckGame.Test.Controllers;

public class HistorysControllerTest
{
    private readonly Mock<IServiceManager> _mockService;
    public HistorysControllerTest()
    {
        _mockService = new Mock<IServiceManager>();
    }

    [Fact]
    public void GetHistorysAsync_ListOfHistorysDto_HistoryExistInRepo()
    {
        // Arrange
        var historys = GetListOfHistory_Test();
        _mockService.Setup(x => x.HistoryService.GetAllHistoryASync(It.IsAny<bool>()))
            .Returns(historys);

        var controller = new HistorysController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetHistorys();
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.IsType<List<HistoryDto>>(actual);
    }

    [Fact]
    public void GetHistoryByIdAsync_OkObjectResultAndHistoryDto_HistoryWithIdExistInRepo()
    {
        // Arrange
        var history = GetHistoryDtoById_Test();
        _mockService.Setup(x => x.HistoryService.GetHistoryAsync(1, It.IsAny<bool>()))
            .Returns(history);

        var controller = new HistorysController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetHistory(1);
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.IsType<HistoryDto>(actual);
    }

    [Fact]
    public void GetHistoryByIdAsync_OkObjectResultAndNullHistoryDto_HistoryWithIdDoesNotExistInRepo()
    {
        // Arrange
        var history = GetHistoryDtoById_Test();
        _mockService.Setup(x => x.HistoryService.GetHistoryAsync(1, It.IsAny<bool>()))
            .Returns(history);

        var controller = new HistorysController(_mockService.Object);

        // Act
        var taskIActionResult = controller.GetHistory(2);
        var result = taskIActionResult.Result as OkObjectResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<OkObjectResult>(result);
        Assert.Null(actual);
    }

    [Fact]
    public void CreateHistory_OkObjectResultAndCreatedAtRoute_CreatingHistory()
    {
        // Arrange
        var history = HistoryDtoForCreation_Test();

        _mockService.Setup(r => r.HistoryService.CreateHistoryAsync(It.IsAny<HistoryForCreationDto>()))
            .ReturnsAsync(new HistoryDto()
            {
                Id = 6,
                Round = 3,
                CardId = 1,
            });

        var controller = new HistorysController(_mockService.Object);

        // Act
        var taskIActionResult = controller.CreateHistory(history);
        _mockService.Verify(x => x.HistoryService.CreateHistoryAsync(It.IsAny<HistoryForCreationDto>()), Times.Once);

        var result = taskIActionResult.Result as CreatedAtRouteResult;
        var actual = result.Value;

        // Assert
        Assert.IsType<CreatedAtRouteResult>(result);
        Assert.IsType<HistoryDto>(actual);
    }

    // Här nedan finns endast skitkod för att skapa "listor" med cards.
    #region List of History
    private static async Task<HistoryDto> GetHistoryDtoById_Test()
    {
        var history = new HistoryDto
        {
            Id = 1,
            Round = 1,
            CardId = 1,
            Card = new CardDto
            {
                Id = 1,
                Name = "Ace of Hearts",
                Suit = "Hearts",
                CardDeckId = 1,
                ImgName = "/images/hearts/ace.png",
                CheckBoxIsActive = false
            }
        };

        return history;
    }

    private static HistoryForCreationDto HistoryDtoForCreation_Test()
    {
        var history = new HistoryForCreationDto
        {
            Round = 3,
            CardId = 1,
        };

        return history;
    }

    private static async Task<IEnumerable<HistoryDto>> GetListOfHistory_Test()
    {
        var historys = new List<HistoryDto>{
            new HistoryDto
            {
                Id = 1,
                Round = 1,
                CardId = 1,
                Card = new CardDto
                {
                    Id = 1,
                    Name = "Ace of Hearts",
                    Suit = "Hearts",
                    CardDeckId = 1,
                    ImgName = "/images/hearts/ace.png",
                    CheckBoxIsActive = false
                }
            },
            new HistoryDto
            {
                Id = 2,
                Round = 2,
                CardId = 4,
                Card = new CardDto
                {
                    Id = 4,
                    Name = "Four",
                    Suit = "Hearts",
                    CardDeckId = 1,
                    ImgName = "/images/hearts/4.png",
                    CheckBoxIsActive = false
                }
            },
            new HistoryDto
            {
                Id = 3,
                Round = 3,
                CardId = 12,
                Card = new CardDto
                {
                    Id = 12,
                    Name = "Queen",
                    Suit = "Hearts",
                    CardDeckId = 1,
                    ImgName = "/images/hearts/queen.png",
                    CheckBoxIsActive = false
                }
            },
            new HistoryDto
            {
                Id = 4,
                Round = 4,
                CardId = 51,
                Card = new CardDto
                {
                    Id = 51,
                    Name = "Queen",
                    Suit = "Diamonds",
                    CardDeckId = 1,
                    ImgName = "/images/diamonds/queen.png",
                    CheckBoxIsActive = false
                }
            }};

        return historys;
    }
    #endregion
}
