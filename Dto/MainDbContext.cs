using Microsoft.EntityFrameworkCore;
using Umbrella.Dto.Models.Base;

namespace Umbrella.Dto;

public class MainDbContext : DbContext
{
    public virtual DbSet<Migrations> Migrations { get; set; }
    public virtual DbSet<Migrations> Movies { get; set; }
}