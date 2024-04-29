using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageDesignApplication
{
    public class Car : Vehicle
    {        public Car()
        {
            spotsNeeded = 1;
            size = VehicleSize.Car;
           // spotSize = ParkingSpotSize.Compact;
        }

        /* Checks if the spot is a Compact or a Large. */
        public override bool CanFitInSpot(ParkingSpot spot)
        {
            //...
            bool _canTheCarParkInSpot = false;

            int getParkingSpotForCar;
            getParkingSpotForCar = GetSpotsNeeded(size);

            if (getParkingSpotForCar == spotsNeeded)
            {
                _canTheCarParkInSpot = true;
            }

            return _canTheCarParkInSpot;
        }

        public override int GetSpotsNeeded(VehicleSize size)
        {           
            return 1;
            
            throw new NotImplementedException();
        }
    }
}
