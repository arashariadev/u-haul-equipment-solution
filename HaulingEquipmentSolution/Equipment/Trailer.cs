using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulingEquipmentSolution.Equipment
{
    public class Trailer : UHaulEquipment
    {
        public int MaxCargoWeight { get; private set; }

        public Trailer(int maxCargoWeight, int numberOfWheels)
        {
            NumberOfWheels = numberOfWheels;
            MaxCargoWeight = maxCargoWeight;
        }
    }
}
