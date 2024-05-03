// See https://aka.ms/new-console-template for more information

using HaulingEquipmentSolution.Equipment;

MovingTruck truck = new MovingTruck(2000, 5000);
Trailer trailer = new Trailer(1600, 2);
TowDolly dolly = new TowDolly(3000, 4);
ElectricCart cart = new ElectricCart();

// Perform tests
Console.WriteLine("Testing Tow Ratings:");
Console.WriteLine($"Moving Truck Tow Rating: {UHaulEquipmentValidation.GetTowRating(truck)}");
Console.WriteLine($"Tow Dolly Tow Rating: {UHaulEquipmentValidation.GetTowRating(dolly)}");

Console.WriteLine("\nTesting Heavy Duty Check:");
Console.WriteLine($"Is Moving Truck Heavy Duty? {UHaulEquipmentValidation.IsHeavyDuty(truck)}");
Console.WriteLine($"Is Trailer Heavy Duty? {UHaulEquipmentValidation.IsHeavyDuty(trailer)}");

Console.WriteLine("\nTesting Toll Fees:");
Console.WriteLine($"Moving Truck Toll Fees: {UHaulEquipmentValidation.GetTollFees(truck, 2.50M)}");
Console.WriteLine($"Trailer Toll Fees: {UHaulEquipmentValidation.GetTollFees(trailer, 2.50M)}");
Console.WriteLine($"Tow Dolly Toll Fees: {UHaulEquipmentValidation.GetTollFees(dolly, 2.50M)}");
Console.WriteLine($"Electric Cart Toll Fees: {UHaulEquipmentValidation.GetTollFees(cart, 2.50M)}");

// Trying to get tow rating for an Electric Cart (should fail)
try
{
    Console.WriteLine($"Electric Cart Tow Rating: {UHaulEquipmentValidation.GetTowRating(cart)}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
Console.ReadLine(); 
