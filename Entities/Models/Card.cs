using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Card
{
    [Key]
    [Column("CardId")]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Suit { get; set; } = string.Empty;
    public string ImgName { get; set; } = string.Empty;

    [ForeignKey(nameof(CardDeck))]
    public int CardDeckId { get; set; }
    public virtual CardDeck? CardDeck { get; set; }
}
