namespace SpecificationPattern.Infrastructure.Base;

public class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T>
    where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).IsRequired().HasDefaultValueSql("NEWID()");
    }
}
