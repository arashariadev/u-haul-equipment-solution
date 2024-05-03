using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaulingEquipmentSolution.Equipment
{
    internal static class UHaulEquipmentValidation
    {
        public static int GetTowRating(UHaulEquipment equipment)
        {
            switch (equipment)
            {
                case MovingTruck truck:
                    return truck.TowRating;
                case TowDolly dolly:
                    return dolly.TowRating;
                default:
                    throw new InvalidOperationException("Tow rating is not applicable for this equipment type.");
            }
        }

        public static bool IsHeavyDuty(UHaulEquipment equipment)
        {
            if (equipment is MovingTruck truck)
            {
                return truck.MaxCargoWeight > 1500;
            }
            else if (equipment is Trailer trailer)
            {
                return trailer.MaxCargoWeight > 1500;
            }
            throw new InvalidOperationException("Max Cargo Weight is not defined for this equipment type.");
        }

        public static decimal GetTollFees(UHaulEquipment equipment, decimal tollAmount)
        {
            return equipment.GetNumberOfAxles() * tollAmount;
        }
    }
}
