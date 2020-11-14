﻿namespace WardrobeT.Data
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

        public DbSet<Cloath> Cloaths { get; set; }

        public DbSet<Friends> Friends { get; set; }

        public DbSet<TypeOfCloath> TypesOfCloath { get; set; }

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

            builder.Entity<TypeOfCloath>().HasData(
                new TypeOfCloath { Type = "Dress", Official = true, CanBeUsedAlone = true },
                new TypeOfCloath { Type = "Dress", Official = false, CanBeUsedAlone = true },
                new TypeOfCloath { Type = "Jacket", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Jacket", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Knit Shirt", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Knit Shirt", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Shirt", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Shirt", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Suit", Official = true, CanBeUsedAlone = true },
                new TypeOfCloath { Type = "Blouse", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Blouse", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Sport Shirt", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Sport Shirt", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Skirt", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Skirt", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Blazer", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Blazer", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Jeans", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Jeans", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Tie", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Tie", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Tunic", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Tunic", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Vest", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Vest", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Short", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Short", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Bowtie", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Bowtie", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Coat", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Slacks", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Slacks", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Leggins", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Turtle Neck", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "Turtle Neck", Official = false, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "T-Shirt", Official = true, CanBeUsedAlone = false },
                new TypeOfCloath { Type = "T-Shirt", Official = false, CanBeUsedAlone = false }
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
