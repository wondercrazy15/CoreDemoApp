using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace DemoApp.Data
{

    public interface IApplicationDbContext
    {
        DbSet<UserInfo> UserInfo { get; set; }
        DbSet<UserAlbum> UserAlbum { get; set; }
        DbSet<UserAlbumPhoto> UserAlbumPhoto { get; set; }
        
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }

    public class DemoAppContext : IdentityDbContext, IApplicationDbContext
    {
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserAlbum> UserAlbum { get; set; }
        public virtual DbSet<UserAlbumPhoto> UserAlbumPhoto { get; set; }

        public DemoAppContext(DbContextOptions<DemoAppContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        

        //public DbSet<UserInfo> UserInfo { get; set; }
        //public DbSet<UserAlbum> UserAlbum { get; set; }
        //public DbSet<UserAlbumPhoto> UserAlbumPhoto { get; set; }
    }

    
}
