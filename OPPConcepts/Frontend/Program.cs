using Backend;

try
{
    var employees = new List<Employee>();
    decimal payroll = 0;
    var employee1 = new SalaryEmployee(1010, "Maria", "Perez", true, new Date(1990, 5, 15), new Date(2020, 1, 10), 2500000);
    employees.Add(employee1);
    var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzalez", true, new Date(1980, 3, 5), new Date(2016, 11, 16), 10395876);
    employees.Add(employee2);
    var employee3 = new HourlyEmployee(3030, "Ana", "Lopez", true, new Date(1995, 8, 20), new Date(2022, 6, 1), 18000, 95);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee(4040, "Kevin", "Rua", true, new Date(1998, 8, 20), new Date(2021, 6, 1), 10000, 112);
    employees.Add(employee4);
    var employee5 = new CommisionEmployee(5050, "Sofia", "Gomez", true, new Date(1992, 12, 10), new Date(2018, 3, 15), 0.03f, 600000000);
    employees.Add(employee5);
    var employee6 = new CommisionEmployee(6060, "Diego", "Martinez", true, new Date(1985, 7, 30), new Date(2010, 9, 1), 0.03f, 120000000);
    employees.Add(employee6);

    foreach (var employee in employees)
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();
    }
    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"Payroll..................: {payroll,20:C2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

