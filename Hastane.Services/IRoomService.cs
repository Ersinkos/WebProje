using Hastane.Utilities;
using Hastane.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Services
{
	public interface IRoomService
	{
		PagedResult<RoomViewModel> GetAll(int pageNumber, int pageSize);
		RoomViewModel GetRoomById(int id);
		void UpdateRoom(RoomViewModel room);
		void InsertRoom(RoomViewModel room);
		void DeleteRoom(int id);
	}
}
