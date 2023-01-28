using Zad9.DTO;
using Zad9.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zad9.Helpers;

namespace Zad9.Services
{
    public interface IPrescriptionDbService
    {
        Task<ResponseHelper> GetPrescriptionAsync(int id);

        /*
        Task<IActionResult> GetDoctorsListAsync();
        Task<IActionResult> AddDoctorAsync(DoctorDTO dto);
        Task<IActionResult> ChangeDoctorAsync(int id, DoctorDTO dto);
        Task<IActionResult> DeleteDoctorAsync(int id);
        Task<IActionResult> GetPrescriptionAsync(int id);
        */
    }
}
