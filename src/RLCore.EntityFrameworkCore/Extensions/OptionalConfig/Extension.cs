using Microsoft.EntityFrameworkCore;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Entities;

namespace RLCore.Extensions.OptionalConfig
{
    public static class Extension
    {
        public static void HasSingleTableOptionalTree(this ModelBuilder builder)
        {
            builder.Entity<SingleTableOptionalTree>().HasMany(e => e.Subs).WithOne(o => o.Parent).HasForeignKey(j => j.ParentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<SingleTableOptionalTree>().HasIndex(u => u.OptionType);
            builder.Entity<SingleTableOptionalTree>().HasIndex(u => u.Option);
            builder.Entity<SingleTableOptionalTree>().HasIndex(u => u.ParentId);
            builder.Entity<SingleTableOptionalTree>().HasIndex(u => u.CreationTime);
        }

        public static void HasPerTableOptionalTree<TOption>(this ModelBuilder builder)
            where TOption : PerTableOptionalTree<TOption>
        {
            builder.Entity<TOption>().HasMany(e => e.Subs).WithOne(o => o.Parent).HasForeignKey(j => j.ParentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<TOption>().HasIndex(u => u.Option);
            builder.Entity<TOption>().HasIndex(u => u.ParentId);
            builder.Entity<TOption>().HasIndex(u => u.CreationTime);
        }

        public static void HasPerTableOptionalTree<TOption, TPrimaryKey>(this ModelBuilder builder)
            where TOption : PerTableOptionalTree<TOption, TPrimaryKey>
        {
            builder.Entity<TOption>().HasMany(e => e.Subs).WithOne(o => o.Parent).HasForeignKey(j => j.ParentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<TOption>().HasIndex(u => u.Option);
            builder.Entity<TOption>().HasIndex(u => u.ParentId);
            builder.Entity<TOption>().HasIndex(u => u.CreationTime);
        }
    }
}
