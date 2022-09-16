using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;
public class History
{
    [Key]
    [Column("HistoryId")]
    public int Id { get; set; }
    public int Round { get; set; }

    [ForeignKey(nameof(Card))]
    public int CardId { get; set; }
    public Card? Card { get; set; }
}
