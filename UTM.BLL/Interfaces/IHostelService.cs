using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UTM.BLL.ViewModels;
using UTM.DLL.Models.HostelModels;

namespace UTM.BLL.Interfaces
{
    public interface IHostelService
    {
        Task<ResultModel<IEnumerable<Hostel>>> GetAllHostelsAsync();
        Task<ResultModel> AddNewHostelAsync(AddHostelViewModel model);
        Task<ResultModel<Hostel>> GetHostelByIdAsync(Guid? hostelId);
        Task<ResultModel> DeleteHostelByIdAsync(Guid? hostelId);
        Task<ResultModel> AddFloorToHostel(AddFloorViewModel model);
        Task<ResultModel<IEnumerable<Floor>>> GetHostelFloorsAsync(Guid hostelId);
        Task<ResultModel> AddNewRoomAsync(AddRoomViewModel model);
    }
}