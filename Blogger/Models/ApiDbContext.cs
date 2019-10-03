using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Data.

namespace Blogger.Models
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Post> PostsList { get; set; }
        public DbSet<User> UsersList { get; set; }
        public DbSet<Blog> BlogList { get; set; }
        public DbSet<Comment> CommentList { get; set; }
        public User Include { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Blogger;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityTypeBuilder<Post> post = modelBuilder.Entity<Post>();
            post.ToTable("Post");
            post.HasKey(entity => entity.ID);
            post.Property(entity => entity.PostTitle).IsRequired();
            post.Property(entity => entity.PostTitle).HasMaxLength(30);
            post.Property(entity => entity.PostContent).IsRequired();
            post.Property(entity => entity.PostContent).HasMaxLength(1000);

            //post.HasMany(e => e.CommentList).WithOne().HasForeignKey(e => e.Post);
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<User>().HasMany(e => e.CommentList).WithOne(c => c.User).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Post>().HasMany(e => e.CommentList).WithOne(c => c.Post).OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Comment>().HasOne(e => e.User).WithMany().OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
