namespace Prototype.PrototypeInheritance;

public class Employee : Person, IDeepCopyable<Employee>
{
    public int Salary;

    public void CopyTo(Employee target)
    {
        base.CopyTo(target);
        target.Salary = Salary;
    }

    public override string ToString() => $"{base.ToString()}, Salary: {Salary}";
}