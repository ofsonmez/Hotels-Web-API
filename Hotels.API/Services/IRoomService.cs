using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hotels.API.Models.Derived;

namespace Hotels.API.Services
{
    public interface IRoomService
    {
        Task<List<Room>> GetRoomsAsync();

        Task<Room> getRoomAsync(Guid id);
    }
}