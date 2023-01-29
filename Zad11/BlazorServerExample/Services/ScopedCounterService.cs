namespace BlazorServerExample.Services
{
    public interface ICounterService2
    {
        public int Counter { get; set; }
    }

    public class ScopedCounterService : ICounterService2
    {
        public int Counter { get; set; }
    }
}
