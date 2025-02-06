using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Hotel : IRoom<RoomAC> , IRoom<RoomNonAC>
    {
        List<RoomAC> lstrooms = new List<RoomAC>()
        {
            new RoomAC(){RoomNo=111,RoomType="Single",Price=5000},
            new RoomAC(){RoomNo=113,RoomType="Single",Price=5000},
            new RoomAC(){RoomNo=112,RoomType="Double",Price=8000},
            new RoomAC(){RoomNo=114,RoomType="Single",Price=5000},

        };

        List<RoomNonAC> lstroomsn = new List<RoomNonAC>()
        {
            new RoomNonAC(){RoomNo=111,RoomType="Single",Price=30},
            new RoomNonAC(){RoomNo=113,RoomType="Single",Price=20},
            new RoomNonAC(){RoomNo=112,RoomType="Double",Price=40},
            new RoomNonAC(){RoomNo=114,RoomType="Single",Price=30},

        };

        public void AddRoom(RoomAC item)
        {
            lstrooms.Add(item);
            Console.WriteLine("Room added successfully" + item.RoomNo + " " + item.RoomType + " " + item.Price);
        }

        public void AddRoom(RoomNonAC itemn)
        {
            lstroomsn.Add(itemn);
            Console.WriteLine("Room added successfully" + itemn.RoomNo + " " + itemn.RoomType + " " + itemn.Price);

        }

        IEnumerable<RoomNonAC> IRoom<RoomNonAC>.GetAll()
        {
            return lstroomsn;
        }

        IEnumerable<RoomAC> IRoom<RoomAC>.GetAll()
        {
            return lstrooms;
        }
    }
}
