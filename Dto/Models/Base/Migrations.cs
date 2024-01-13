using System.ComponentModel.DataAnnotations.Schema;

namespace Umbrella.Dto.Models.Base;

[Table("sys_migrations")]
public class Migrations
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime? AppliedAt { get; set; }
}