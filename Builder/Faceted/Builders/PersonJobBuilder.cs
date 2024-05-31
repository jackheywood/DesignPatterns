namespace Builder.Faceted.Builders;

public class PersonJobBuilder : PersonBuilder
{
    // Might not work with a value type!
    public PersonJobBuilder(Person person)
    {
        Person = person;
    }

    public PersonJobBuilder At(string companyName)
    {
        Person.CompanyName = companyName;
        return this;
    }

    public PersonJobBuilder AsA(string position)
    {
        Person.Position = position;
        return this;
    }

    public PersonJobBuilder Earning(int annualIncome)
    {
        Person.AnnualIncome = annualIncome;
        return this;
    }
}