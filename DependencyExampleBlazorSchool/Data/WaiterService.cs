namespace DependencyExampleBlazorSchool.Data
{
    public class WaiterService
    {
        private readonly GreetingService _greetingService;

        public WaiterService(GreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public string Serve()
        {
            string greeting = _greetingService.Greet();

            return $"{greeting}. How can I help you?";
        }
    }
}