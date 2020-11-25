namespace WardrobeT.Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using WardrobeT.Data.Common.Models;
    using WardrobeT.Data.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Wardrobe.Data;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ApplicationDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Wear> Wears { get; set; }

        public DbSet<Followers> Followers { get; set; }

        public DbSet<TypeOfWear> TypesOfWears { get; set; }

        public DbSet<Outfit> Outfits { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            builder.Entity<TypeOfWear>().HasData(
                new TypeOfWear { Type = "Tracksuit top", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Tracksuit bottoms", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official dress", Official = true, CanBeUsedAlone = true },
                new TypeOfWear { Type = "Dress", Official = false, CanBeUsedAlone = true },
                new TypeOfWear { Type = "Official jacket", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Jacket", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official knit Shirt", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Knit Shirt", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official sirt", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Shirt", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Suit", Official = true, CanBeUsedAlone = true },
                new TypeOfWear { Type = "Official blouse", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Blouse", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Sport Shirt", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official skirt", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Skirt", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official blazer", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Blazer", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official jeans", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Jeans", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official tie", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Tie", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official tunic", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Tunic", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official vest", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Vest", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official short", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Short", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official bowtie", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Bowtie", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Coat", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official slacks", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Slacks", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Leggins", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official turtle Neck", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Turtle Neck", Official = false, CanBeUsedAlone = false },
                new TypeOfWear { Type = "Official T-Shirt", Official = true, CanBeUsedAlone = false },
                new TypeOfWear { Type = "T-Shirt", Official = false, CanBeUsedAlone = false }
                );

            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        // Applies configurations
        private void ConfigureUserIdentityRelations(ModelBuilder builder)
             => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
