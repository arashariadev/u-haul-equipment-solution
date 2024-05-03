using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulingEquipmentSolution.Equipment
{


    public abstract class UHaulEquipment
    {
        public int NumberOfWheels { get; protected set; }

        // Calculates the number of axles based on the number of wheels
        public int GetNumberOfAxles() => (NumberOfWheels + 1) / 2;
    }

}
