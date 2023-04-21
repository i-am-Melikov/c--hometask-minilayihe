using EmployeApp.App.Services.Implementations;
using EmployeApp.App.Services.Interfaces;

IEmployeServices employeService = new EmployeServices();
Console.WriteLine("0.Close");
Console.WriteLine("1.Create");
Console.WriteLine("2.Update");
Console.WriteLine("3.Show by id");
Console.WriteLine("4.Show all");
Console.WriteLine("5.Delete");
Console.WriteLine("6.Delete all");
string Request = Console.ReadLine();
while(Request != "0")
{
    switch(Request)
    {
        case "1":
            employeService.Create();
            break;
        case "2":
            employeService.Update();
            break;
        case "3":
            employeService.ShowById();
            break;
        case "4":
            employeService.ShowAll();
            break;
        case "5":
            employeService.Delete();
            break;
        case "6":
            employeService.DeleteAll();
            break;
            default:
            Console.WriteLine("Select valid option");
            break;
    }
    Console.WriteLine("0.Close");
    Console.WriteLine("1.Create");
    Console.WriteLine("2.Update");
    Console.WriteLine("3.Show by id");
    Console.WriteLine("4.Show all");
    Console.WriteLine("5.Delete");
    Console.WriteLine("6.Delete all");
    Request = Console.ReadLine();
}