using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageDesignApplication
{
    public enum  VehicleSize
    {
        MotorCycle = 0,
        Car = 1,    
        Van = 2,
        Bus = 3,
    }

    public enum ParkingSpotState
    {       
        Vacant = 1,
        Occupied = 2,
    }

    public enum ParkingSpotSize
    {
        Large = 0,  
        Compact = 1,    
    }
}
