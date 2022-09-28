using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;
public class HistoryConfiguration : IEntityTypeConfiguration<History>
{
    public void Configure(EntityTypeBuilder<History> builder)
    {
        builder.HasData
        (
            new History
            {
                Id = 1,
                Round = 1,
                CardId = 1
            },
            new History
            {
                Id = 2,
                Round = 2,
                CardId = 4
            },
            new History
            {
                Id = 3,
                Round = 3,
                CardId = 12
            },
            new History
            {
                Id = 4,
                Round = 4,
                CardId = 51
            });
    }
}
