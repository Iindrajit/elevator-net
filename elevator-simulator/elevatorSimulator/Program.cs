// See https://aka.ms/new-console-template for more information
using elevatorSimulator;

Elevator elevator = new Elevator();

Console.WriteLine("The elevator is currently at Floor 0 (Ground floor).");

while (true)
{
    Console.WriteLine("Enter 1: Call the elevator, 2: Select a floor, or 0: Exit:");
    int selectedOption;
    if (!int.TryParse(Console.ReadLine(), out selectedOption))
    {
        Console.WriteLine("Invalid input.");
        continue;
    }

    switch (selectedOption)
    {
        case 0:
            Console.WriteLine("Exiting...");
            return;
        case 1:
            Console.WriteLine("Enter the floor number to call the elevator:");
            int callToFloor;
            if (!int.TryParse(Console.ReadLine(), out callToFloor))
            {
                Console.WriteLine("Invalid input. Please enter a valid floor number.");
                continue;
            }
            elevator.Get(callToFloor);
            break;
        case 2:
            Console.WriteLine("Enter the destination floor:");
            int destFloor;
            if (!int.TryParse(Console.ReadLine(), out destFloor))
            {
                Console.WriteLine("Invalid input. Please enter a valid floor number.");
                continue;
            }
            elevator.SelectFloor(destFloor);
            break;
        default:
            Console.WriteLine("Invalid input. Please enter a valid option.");
            break;
    }
}
        
