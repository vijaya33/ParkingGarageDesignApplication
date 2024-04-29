using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageDesignApplication
{
    public class Van : Vehicle
    {
        public Van()
        {
            spotsNeeded = 5;
            size = VehicleSize.Van;
        }

        /* Checks if the spot is a Large. Doesn't check
         num of spots */
        public override bool CanFitInSpot(ParkingSpot spot)
        {
            //...
            bool _canTheVanParkInSpot = false;

            int numberParkingSpotsForVan;
            numberParkingSpotsForVan =  GetSpotsNeeded(size); 
            
            if (numberParkingSpotsForVan == spotsNeeded)
            {
                _canTheVanParkInSpot = true;
            }

            return _canTheVanParkInSpot;
        }

        public override int GetSpotsNeeded(VehicleSize size)
        {
            //// Check if the consecutive 5 spots are vacant.
            //ParkingSpot parkingSpot;
            //for(int i = 0; i <5; i++)
            //{
            //    if (parkingSpot[i].spotSize == ParkingSpotSize.Large)
            //    {

            //    }
            //}
            //if(spotSize == ParkingSpotSize.Large)
            return 5;
            //throw new NotImplementedException();
        }
    }
}
