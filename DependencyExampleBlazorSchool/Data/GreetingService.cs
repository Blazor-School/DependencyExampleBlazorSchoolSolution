namespace DependencyExampleBlazorSchool.Data
{
    public class GreetingService
    {
        public string Greet()
        {
            return $"Hello World from {nameof(GreetingService)}";
        }
    }
}
