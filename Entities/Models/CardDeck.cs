using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// Class för kortlek. Använder en virtuel lista av classen-Cards.
/// </summary>
public class CardDeck
{
    [Key]
    [Column("CardDeckId")]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TotalCards { get; set; }
    public string ImgName { get; set; } = string.Empty;

    public virtual ICollection<Card>? Cards { get; set; }
}
