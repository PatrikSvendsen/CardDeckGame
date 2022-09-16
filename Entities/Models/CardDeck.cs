using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class CardDeck
{
    [Key]
    [Column("CardDeckId")]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int TotalCards { get; set; }

    public ICollection<Card>? Cards { get; set; }

}
