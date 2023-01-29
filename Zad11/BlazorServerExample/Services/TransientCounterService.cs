namespace BlazorServerExample.Services
{
    public interface ICounterService3
    {
        public int Counter { get; set; }
    }

    public class TransientCounterService : ICounterService3
    {
        public int Counter { get; set; }
    }
}
