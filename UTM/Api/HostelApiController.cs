using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UTM.BLL;
using UTM.BLL.Extensions;
using UTM.BLL.Interfaces;
using UTM.BLL.ViewModels;
using UTM.DLL.Models.HostelModels;

namespace UTM.Presentation.Api
{
    [Authorize]
    public class HostelApiController : Controller
    {
        private readonly IHostelService _hostelService;

        public HostelApiController(IHostelService hostelService)
        {
            _hostelService = hostelService;
        }

        [HttpPost]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel))]
        public async Task<JsonResult> AddNewHostel(AddHostelViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new ResultModel().AttachModelState(ModelState));
            }

            return Json(await _hostelService.AddNewHostelAsync(model));
        }


        [HttpGet]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel<IEnumerable<Hostel>>))]
        public async Task<JsonResult> GetAllHostels()
            => Json(await _hostelService.GetAllHostelsAsync());



        [HttpGet]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel<Hostel>))]
        public async Task<JsonResult> GetHostelById(Guid hostelId)
            => Json(await _hostelService.GetHostelByIdAsync(hostelId));

        [HttpGet]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel<IEnumerable<Room>>))]
        public async Task<JsonResult> GetFloorRooms(Guid floorId)
            => Json(await _hostelService.GetFloorRoomsAsync(floorId));


        [HttpGet]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel<IEnumerable<Floor>>))]
        public async Task<JsonResult> GetHostelFloors(Guid hostelId)
            => Json(await _hostelService.GetHostelFloorsAsync(hostelId));


        [HttpDelete]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel))]
        public async Task<JsonResult> DeleteHostel(Guid hostelId)
            => Json(await _hostelService.DeleteHostelByIdAsync(hostelId));

        [HttpPost]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel))]
        public async Task<JsonResult> AddRoom(AddRoomViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new ResultModel().AttachModelState(ModelState));
            }

            return Json(await _hostelService.AddNewRoomAsync(model));
        }

        [HttpPost]
        [Route("api/[controller]/[action]")]
        [Produces("application/json", Type = typeof(ResultModel))]
        public async Task<JsonResult> AddFloor(AddFloorViewModel model)
        {
            return !ModelState.IsValid ? Json(new ResultModel().AttachModelState(ModelState)) : Json(await _hostelService.AddFloorToHostel(model));
        }

    }
}
