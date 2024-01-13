using System.ComponentModel.DataAnnotations.Schema;

namespace Umbrella.Dto.Models;

[Table("movies")]
public class Movies
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTimeOffset ReleaseDate { get; set; }
}