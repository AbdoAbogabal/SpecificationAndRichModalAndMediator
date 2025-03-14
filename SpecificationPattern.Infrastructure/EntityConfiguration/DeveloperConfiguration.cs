namespace SpecificationPattern.Infrastructure.EntityConfiguration;

public class DeveloperConfiguration : BaseEntityConfiguration<Developer>
{
    public override void Configure(EntityTypeBuilder<Developer> builder)
    {
        builder.ToTable("Developers");

        builder.HasOne(e => e.Address).WithMany().OnDelete(DeleteBehavior.Restrict);

        builder.OwnsOne(e => e.DeveloperName, name =>
        {
            name.Property(n => n.Value).IsRequired();
            name.Property(n => n.Value).HasColumnName("Name");
        });

        builder.OwnsOne(e => e.DeveloperEmail, email =>
                                               email.Property(n => n.Value)
                                                    .HasColumnName("Email")
                                                    .IsRequired());

        builder.OwnsOne(e => e.DeveloperYearsOfExperience, yearsOfExperience =>
                                                           yearsOfExperience.Property(n => n.Value)
                                                                            .HasColumnName("YearsOfExperience")
                                                                            .IsRequired());

        builder.OwnsOne(e => e.DeveloperEstimatedIncome, estimatedIncome =>
                                                         estimatedIncome.Property(n => n.Value)
                                                                        .HasColumnName("EstimatedIncome")
                                                                        .IsRequired());

        base.Configure(builder);
    }
}
