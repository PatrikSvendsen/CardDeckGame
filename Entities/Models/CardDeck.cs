using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class CardDeck
{
    [Key]
    [Column("CardDeckId")]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TotalCards { get; set; } = 52;
    public string ImgName { get; set; } = string.Empty;

    public ICollection<Card>? Cards { get; set; }
}
