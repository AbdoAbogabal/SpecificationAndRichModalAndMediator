namespace SpecificationPattern.Infrastructure.EntityConfiguration;

public class AddressConfiguration : BaseEntityConfiguration<Address>
{
    public override void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.OwnsOne(e => e.AddressStreet, street =>
                                              street.Property(n => n.Value)
                                                    .HasColumnName("Street")
                                                    .IsRequired());

        builder.OwnsOne(e => e.AddressCity, city =>
                                            city.Property(n => n.Value)
                                                .HasColumnName("City")
                                                .IsRequired());

        base.Configure(builder);
    }
}
