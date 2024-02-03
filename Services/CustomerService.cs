namespace ConsoleAppWithDI.Services;

public class CustomerService: ICustomerService
{
    public void CalculateCustomerAge(int id)
    {
        Console.WriteLine("");
        Console.WriteLine("From CustomerService.cs :");
        Console.WriteLine("CalculateCustomerAge runs!");
        Console.WriteLine("DI working!");
    }
}