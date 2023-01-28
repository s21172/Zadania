using System.Threading.Tasks;
using Zad8.DTO;
using Zad8.Helpers;

namespace Zad8.Services
{
    public interface IDoctorDbService
    {
        Task<ResponseHelper> GetDoctorsListAsync();
        Task<ResponseHelper> AddDoctorAsync(DoctorDTO doctor);
        Task<ResponseHelper> ChangeDoctorsAsync(int id, DoctorDTO doctor);
        Task<ResponseHelper> DeleteDoctorsAsync(int id);
    }
}
