using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OwnedEntities.Ordering;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace OwnedEntities.EntityFrameworkCore
{
    public static class OwnedEntitiesDbContextModelCreatingExtensions
    {
        public static void ConfigureOwnedEntities(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(OwnedEntitiesConsts.DbTablePrefix + "YourEntities", OwnedEntitiesConsts.DbSchema);

            //    //...
            //});
            
            builder.Entity<Order>(b =>
            {
                b.ToTable(OwnedEntitiesConsts.DbTablePrefix + "Orders", OwnedEntitiesConsts.DbSchema);
                
                b.ConfigureByConvention();
                b.TryConfigureFullAudited();
                
                b.OwnsMany(x => x.OrderLines)
                    .WithOwner()
                    .HasForeignKey(x => x.OrderId);
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}