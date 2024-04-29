using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageDesignApplication
{
    public abstract class Vehicle
    {
        protected List<ParkingSpot> parkingSpots =
                           new List<ParkingSpot>();

        
        protected String licensePlate;
        protected int spotsNeeded;
        protected VehicleSize size;
        protected ParkingSpotState spotStatus;
        protected ParkingSpotSize spotSize;
        public abstract int GetSpotsNeeded(VehicleSize size);
               
        /* Remove vehicle from spot, and notify spot
        that it's gone */
        public void clearSpots() 
        {
            // set the spot status to Occupied or / vacant. 
            spotStatus = ParkingSpotState.Vacant; // this spot is available for other vehicles to park. 
        }

        /* Checks if the spot is big enough for the
           vehicle (and is available).
           This * compares the SIZE only.It does not
          check if it has enough spots. */
        public abstract bool CanFitInSpot(ParkingSpot spot);       
        
    }
}
