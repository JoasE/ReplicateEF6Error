using System.Data.Entity;

namespace TestWebApp.Models
{
    public class TestWebAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TestWebAppContext() : base("name=TestWebAppContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Give posts and comments dedicated tables.
            modelBuilder.Entity<Post>().ToTable("Posts");
            modelBuilder.Entity<Comment>().ToTable("Comments");

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<TestWebApp.Models.Post> Posts { get; set; }

        public System.Data.Entity.DbSet<TestWebApp.Models.Comment> Likables { get; set; }
    }
}
