namespace Backend;

public class BaseCommisionEmployee : CommisionEmployee
{
    // Fields

    private decimal _salary;

    // Constructors

    public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPercentaje, decimal sales, decimal salary) : base(id, firstName, lastName, isActive, bornDate, hireDate, commisionPercentaje, sales)
    {
        Salary = salary;
    }

    // Properties

    public decimal Salary 
    { 
        get => _salary; 
        set => _salary = ValidateSalary(value); 
    }

    // Methods

    public override decimal GetValueToPay() => (decimal)CommisionPercentaje * Sales + Salary;

    public override string ToString() => base.ToString() + $"\n\t" +
        $"Salary...........: {Salary,20:C2}";

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to 0");
        }
        return salary;
    }
}
