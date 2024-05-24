using Microsoft.EntityFrameworkCore;
using TempProject.Service.Controling.Infrastructure.DataBase.Server.Table;

namespace TempProject.Service.Controling.Infrastructure.DataBase.Server;

public partial class TestProjectContext : DbContext
{
    public TestProjectContext()
    {
    }

    public TestProjectContext(DbContextOptions<TestProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=46.242.128.133;port=8888;user=UserTestProject;password=test123;database=TestProject", ServerVersion.Parse("8.4.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.ToTable("Status");

            entity.Property(e => e.IdStatus).HasColumnName("idStatus");
            entity.Property(e => e.Description).HasMaxLength(45);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
