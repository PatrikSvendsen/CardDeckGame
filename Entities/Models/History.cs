using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

/// <summary>
/// History class. Har en koppling till classen Card via Id.
/// </summary>
public class History
{
    [Key]
    [Column("HistoryId")]
    public int Id { get; set; }
    public int Round { get; set; }

    [ForeignKey(nameof(Card))]
    public int CardId { get; set; }
    public virtual Card? Card { get; set; }
}
