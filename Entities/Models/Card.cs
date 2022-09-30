using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Card-classen används för enskilda kort. Har en virtuel koppling till kortlek. 
/// </summary>
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
