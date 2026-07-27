using Microsoft.EntityFrameworkCore;
using Pyre.Dev.Models;
using System.Security.Principal;

public class PyreDevDbContext : DbContext
{
    public PyreDevDbContext(DbContextOptions<PyreDevDbContext> options) : base(options) { }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Bank> Banks { get; set; }
}