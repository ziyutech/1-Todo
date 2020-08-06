using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Todo.Api.Models
{
    public partial class todoContext : DbContext
    {
        public todoContext()
        {
        }

        public todoContext(DbContextOptions<todoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TodoItem> TodoItem { get; set; }
        public virtual DbSet<TodoList> TodoList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;userid=root;pwd=bmc!1234+;port=3306;database=todo;sslmode=none", x => x.ServerVersion("8.0.15-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>(entity =>
            {
                entity.ToTable("todo_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Etime)
                    .HasColumnName("etime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iscomplete).HasColumnName("iscomplete");

                entity.Property(e => e.ListUid)
                    .HasColumnName("list_uid")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TodoList>(entity =>
            {
                entity.ToTable("todo_list");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ctime)
                    .HasColumnName("ctime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
