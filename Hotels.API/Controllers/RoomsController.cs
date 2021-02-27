using System;
using System.Linq;
using System.Threading.Tasks;
using Hotels.API.Contexts;
using Hotels.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        
        [HttpGet(Name = nameof(GetRooms))]
        public async Task<IActionResult> GetRooms()
        {
            var rooms = await _roomService.GetRoomsAsync();

            if (rooms == null)
                return NoContent();
            
            return Ok(rooms);
        }
    }
}