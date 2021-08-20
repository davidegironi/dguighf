using System.Configuration;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DG.UIGHFSample.Model.Entity
{
    public partial class dguighftestEntities : DbContext
    {
        public dguighftestEntities()
        {
        }

        public dguighftestEntities(DbContextOptions<dguighftestEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<blogs> blogs { get; set; }
        public virtual DbSet<comments> comments { get; set; }
        public virtual DbSet<commentsuseful> commentsuseful { get; set; }
        public virtual DbSet<posts> posts { get; set; }
        public virtual DbSet<postsadditionals> postsadditionals { get; set; }
        public virtual DbSet<poststotags> poststotags { get; set; }
        public virtual DbSet<tags> tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["dguighftestConnectionString"]);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<blogs>(entity =>
            {
                entity.HasKey(e => e.blogs_id);

                entity.HasIndex(e => e.blogs_title, "IX_blogs_title")
                    .IsUnique();

                entity.Property(e => e.blogs_date).HasColumnType("datetime");

                entity.Property(e => e.blogs_description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.blogs_title)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<comments>(entity =>
            {
                entity.HasKey(e => e.comments_id);

                entity.Property(e => e.comments_email)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.comments_text)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.comments_username)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.posts)
                    .WithMany(p => p.comments)
                    .HasForeignKey(d => d.posts_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_comments_posts");
            });

            modelBuilder.Entity<commentsuseful>(entity =>
            {
                entity.HasKey(e => e.commentsuseful_id);

                entity.HasOne(d => d.comments)
                    .WithMany(p => p.commentsuseful)
                    .HasForeignKey(d => d.comments_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_commentsuseful_comments");
            });

            modelBuilder.Entity<posts>(entity =>
            {
                entity.HasKey(e => e.posts_id);

                entity.HasIndex(e => new { e.posts_title, e.blogs_id }, "IX_posts_title")
                    .IsUnique();

                entity.Property(e => e.posts_email)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.posts_text)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.posts_title)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.posts_username)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.blogs)
                    .WithMany(p => p.posts)
                    .HasForeignKey(d => d.blogs_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_posts_blogs");
            });

            modelBuilder.Entity<postsadditionals>(entity =>
            {
                entity.HasKey(e => e.posts_id);

                entity.Property(e => e.posts_id).ValueGeneratedNever();

                entity.Property(e => e.postsadditionals_note).HasColumnType("text");

                entity.HasOne(d => d.posts)
                    .WithOne(p => p.postsadditionals)
                    .HasForeignKey<postsadditionals>(d => d.posts_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_postsadditionals_posts");
            });

            modelBuilder.Entity<poststotags>(entity =>
            {
                entity.HasKey(e => new { e.posts_id, e.tags_id });

                entity.Property(e => e.poststotags_comments)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.posts)
                    .WithMany(p => p.poststotags)
                    .HasForeignKey(d => d.posts_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_poststotags_posts");

                entity.HasOne(d => d.tags)
                    .WithMany(p => p.poststotags)
                    .HasForeignKey(d => d.tags_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_poststotags_tags");
            });

            modelBuilder.Entity<tags>(entity =>
            {
                entity.HasKey(e => e.tags_id);

                entity.Property(e => e.tags_name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
