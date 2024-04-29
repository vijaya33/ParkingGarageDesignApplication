using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageDesignApplication
{
    public class ParkingSpot
    {
        private Vehicle vehicle;
        private VehicleSize vehicleSize;
        private int row;
        private int spotNumber;
        private string level1;
        private ParkingSpotSize spotSize;

        public ParkingSpot(string level, int r, int n,
                             VehicleSize s, ParkingSpotSize parkingSpotSize)
        {
            row = r;
            spotNumber = n;
            level1 = level;
            vehicleSize = s;
            spotSize = parkingSpotSize;
        }
        public Boolean isAvailable()
        {
            return vehicle == null;
        }

        /* Check if the spot is big enough and is available */
        public bool canFitVehicle(Vehicle vehicle) 
        {
            return false;
            ///... 
        }

        /* Park vehicle in this spot. */
        public bool park(Vehicle v) 
        { 
            ///...
            ///
            return false; 
        }

        public int getRow()
        {
            return row;
        }
        public int getSpotNumber()
        {
            return spotNumber;
        }

        /* Remove vehicle from spot, and notify
          level that a new spot is available */
        public void removeVehicle() 
        { 
            ///... 
            
        }
    }
}
