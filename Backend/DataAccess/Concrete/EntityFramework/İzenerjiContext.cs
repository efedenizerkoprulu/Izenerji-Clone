using DataAccess.Mapping;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class İzenerjiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server= EFEDENIZERKOPRU\SQLEXPRESS; Database=IzenerjiProject; Trusted_Connection=True");
        }

        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleDetail> ArticleDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<İmageItem> ImageItems { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<ChartData> ChartDatas { get; set; }
        public DbSet<Twitter> Twitters { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AbilityMap).Assembly);
        }

    }
}
