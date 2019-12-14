using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UTM.BLL;
using UTM.BLL.Extensions;
using UTM.BLL.Interfaces;
using UTM.BLL.ViewModels;
using UTM.DLL.Data;
using UTM.DLL.Models.HostelModels;
using Mapster;

namespace UTM.Presentation.Services
{
    public class HostelService : IHostelService
    {
        private readonly ApplicationDbContext _context;

        public HostelService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all hostels
        /// </summary>
        /// <returns></returns>
        public async Task<ResultModel<IEnumerable<Hostel>>> GetAllHostelsAsync()
        {
            var data = await _context.Hostels.ToListAsync();
            return new ResultModel<IEnumerable<Hostel>>
            {
                IsSuccess = true,
                Result = data
            };
        }

        /// <summary>
        /// Add new hostel
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ResultModel> AddNewHostelAsync(AddHostelViewModel model)
        {
            await _context.Hostels.AddAsync(model.Adapt<Hostel>());
            return await _context.SaveAsync();
        }

        /// <summary>
        /// Get hostel by id
        /// </summary>
        /// <param name="hostelId"></param>
        /// <returns></returns>
        public async Task<ResultModel<Hostel>> GetHostelByIdAsync(Guid? hostelId)
        {
            var response = new ResultModel<Hostel>();
            var hostel = await _context.Hostels.FirstOrDefaultAsync(x => x.Id.Equals(hostelId));
            if (hostel == null)
            {
                response.Errors.Add(new ErrorModel("", "Not found"));
                return response;
            }

            response.IsSuccess = true;
            response.Result = hostel;
            return response;
        }

        /// <summary>
        /// Delete hostel
        /// </summary>
        /// <param name="hostelId"></param>
        /// <returns></returns>
        public async Task<ResultModel> DeleteHostelByIdAsync(Guid? hostelId)
        {
            var hostelRequest = await GetHostelByIdAsync(hostelId);
            if (!hostelRequest.IsSuccess) return hostelRequest.ToBase();
            var hostel = hostelRequest.Result;
            _context.Hostels.Remove(hostel);
            return await _context.SaveAsync();
        }

        public async Task<ResultModel> AddFloorToHostel(AddFloorViewModel model)
        {
            await _context.Floors.AddAsync(model.Adapt<Floor>());
            return await _context.SaveAsync();
        }

        public async Task<ResultModel<IEnumerable<Floor>>> GetHostelFloorsAsync(Guid hostelId)
        {
            var response = new ResultModel<IEnumerable<Floor>>
            {
                Result = await _context.Floors.Where(x => x.HostelId.Equals(hostelId)).ToListAsync(),
                IsSuccess = true
            };
            return response;
        }

        public async Task<ResultModel> AddNewRoomAsync(AddRoomViewModel model)
        {
            await _context.Rooms.AddAsync(model.Adapt<Room>());
            return await _context.SaveAsync();
        }
    }
}
