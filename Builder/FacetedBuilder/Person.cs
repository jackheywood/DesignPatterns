using System.Text;

namespace Builder.FacetedBuilder;

public class Person
{
    // Employment
    public int AnnualIncome;
    public string CompanyName, Position;

    // Address
    public string StreetAddress, City, Postcode;

    public override string ToString() =>
        new StringBuilder()
            .AppendLine("Address:")
            .AppendLine($"  {StreetAddress}")
            .AppendLine($"  {City}")
            .AppendLine($"  {Postcode}")
            .AppendLine($"Company:\n  {CompanyName}")
            .AppendLine($"Position:\n  {Position}")
            .AppendLine($"Annual Income:\n  £{AnnualIncome}")
            .ToString();
}