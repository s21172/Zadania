using System.Threading.Tasks;
using Zad9.DTO;
using Zad9.Helpers;

namespace Zad9.Services
{
    public interface IDoctorDbService
    {
        Task<ResponseHelper> GetDoctorsListAsync();
        Task<ResponseHelper> AddDoctorAsync(DoctorDTO doctor);
        Task<ResponseHelper> ChangeDoctorsAsync(int id, DoctorDTO doctor);
        Task<ResponseHelper> DeleteDoctorsAsync(int id);
    }
}
