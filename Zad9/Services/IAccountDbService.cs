using System.Threading.Tasks;
using Zad9.DTO;
using Zad9.Helpers;

namespace Zad9.Services
{
    public interface IAccountDbService
    {
        Task<ResponseHelper> LoginAsync(LoginDTO loginDTO);
        Task<ResponseHelper> RegisterAsync(RegisterDTO registerDTO);
    }
}
