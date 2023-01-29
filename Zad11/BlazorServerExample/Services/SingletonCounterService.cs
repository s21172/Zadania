namespace BlazorServerExample.Services
{
    public interface ICounterService
    {
        public int Counter { get; set; }
    }

    public class SingletonCounterService : ICounterService
    {
        public int Counter { get; set; }
    }
}
