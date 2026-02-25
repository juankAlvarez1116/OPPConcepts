using Backend;

try
{
    var date1 = new Date();
    var date2 = new Date(250, 10, 30);
    var date3 = new Date(2000, 2, 29);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

