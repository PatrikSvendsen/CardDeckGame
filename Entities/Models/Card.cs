using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Card
{
    [Key]
    [Column("CardId")]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Suit { get; set; }
    public int Value { get; set; }

    [ForeignKey(nameof(CardDeck))]
    public int CardDeckId { get; set; }
    public CardDeck? CardDeck { get; set; }
}
