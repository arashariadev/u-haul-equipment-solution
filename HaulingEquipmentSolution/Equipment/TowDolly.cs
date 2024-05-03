using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulingEquipmentSolution.Equipment
{
    public class TowDolly : UHaulEquipment
    {
        public int TowRating { get; private set; }

        public TowDolly(int towRating, int numberOfWheels)
        {
            NumberOfWheels = numberOfWheels;
            TowRating = towRating;
        }
    }
}
