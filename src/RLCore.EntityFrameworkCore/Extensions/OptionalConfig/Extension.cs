using Microsoft.EntityFrameworkCore;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Entities;

namespace RLCore.Extensions.OptionalConfig
{
    public static class Extension
    {
        public static void HasOptionTreeSharedTableEntity(this ModelBuilder builder)
        {
            builder.Entity<OptionTreeSharedTable>().HasMany(e => e.Subs).WithOne(o => o.Parent).HasForeignKey(j => j.ParentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<OptionTreeSharedTable>().HasIndex(u => u.OptionType);
            builder.Entity<OptionTreeSharedTable>().HasIndex(u => u.Option);
            builder.Entity<OptionTreeSharedTable>().HasIndex(u => u.ParentId);
            builder.Entity<OptionTreeSharedTable>().HasIndex(u => u.CreationTime);
        }

        public static void HasOptionTreeEntity<TOption>(this ModelBuilder builder)
            where TOption : OptionTreeBase<TOption>
        {
            builder.Entity<TOption>().HasMany(e => e.Subs).WithOne(o => o.Parent).HasForeignKey(j => j.ParentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<TOption>().HasIndex(u => u.Option);
            builder.Entity<TOption>().HasIndex(u => u.ParentId);
            builder.Entity<TOption>().HasIndex(u => u.CreationTime);
        }

        public static void HasOptionTreeEntity<TOption, TPrimaryKey>(this ModelBuilder builder)
            where TOption : OptionTreeBase<TOption, TPrimaryKey>
        {
            builder.Entity<TOption>().HasMany(e => e.Subs).WithOne(o => o.Parent).HasForeignKey(j => j.ParentId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<TOption>().HasIndex(u => u.Option);
            builder.Entity<TOption>().HasIndex(u => u.ParentId);
            builder.Entity<TOption>().HasIndex(u => u.CreationTime);
        }
    }
}
