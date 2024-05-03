using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulingEquipmentSolution.Equipment
{
    public class MovingTruck : UHaulEquipment
    {
        public int MaxCargoWeight { get; private set; }
        public int TowRating { get; private set; }

        public MovingTruck(int maxCargoWeight, int towRating)
        {
            NumberOfWheels = 4;
            MaxCargoWeight = maxCargoWeight;
            TowRating = towRating;
        }
    }
}
