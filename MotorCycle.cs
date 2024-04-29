using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageDesignApplication
{
    public class MotorCycle : Vehicle
    {
        public MotorCycle()
        {
            spotsNeeded = 1;
            size = VehicleSize.MotorCycle;
        }
        public override bool CanFitInSpot(ParkingSpot spot)
        {
            //...
            bool _canTheMotorCycleParkInSpot = false;

            int getParkingSpotForCar;
            getParkingSpotForCar = GetSpotsNeeded(size);

            if (getParkingSpotForCar == spotsNeeded)
            {
                _canTheMotorCycleParkInSpot = true;
            }

            return _canTheMotorCycleParkInSpot;
        }

        public override int GetSpotsNeeded(VehicleSize size)
        {
            return 1;

            throw new NotImplementedException();    
        }
    }
}
