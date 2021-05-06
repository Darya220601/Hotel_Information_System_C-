using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Room
    {
        public int roomNumber { get; set; }
        public Boolean isFree { get; set; }

        public   const String typeOne = "singleRoom";
        public  const String typeTwo = "doubleRoom";
        public  const String typeThree = "familyRoom";
       


    }
}
