using ConsoleAppWithDI.Services;
using Microsoft.Extensions.Configuration;

namespace ConsoleAppWithDI
{
    public class App
    {
        private readonly ICustomerService _customerService;
        private readonly IConfiguration _configuration;

        public App(ICustomerService customerService, IConfiguration configuration)
        {
            _customerService = customerService;
            _configuration = configuration;
        }

        public void Run(string[] args)
        {
            Console.WriteLine("This is simple console app a template for a console app w/ DI (Dependency Injection");

            Console.WriteLine("Enjoy!");
            Console.WriteLine("");

            // Print version settings
            var version = _configuration["Version"];
            Console.WriteLine("version " + version);

            // Print ApiSettings sections
            var apiSettings = _configuration.GetRequiredSection("ApiSettings").Get<ApiSettings>();
            Console.WriteLine("Github token " + apiSettings.GitHubToken);
            Console.WriteLine("Bearer token " + apiSettings.BearerToken);

            // Test DI
            _customerService.CalculateCustomerAge(1);
        }
    }
}