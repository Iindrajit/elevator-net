namespace elevatorSimulator
{
    public class Elevator
    {
        private int currentFloorNumber = 0;
        private int destinationFloorNumber = 0;

        /// <summary>
        /// Calls the elevator to the specified floor.
        /// </summary>
        /// <param name="floor">The floor number to which the elevator should be called.
        /// Floors are numbered from 0 (Ground floor) to 20.</param>
        public void Get(int floor)
        {
            if (floor < 0 || floor > 20)
            {
                Console.WriteLine("Please enter a floor number between 0 (Ground floor) and 20.");
                return;
            }

            Console.WriteLine($"Elevator called to floor: {floor}");
            destinationFloorNumber = floor;
            Move();
        }


        /// <summary>
        /// Selects the destination floor for the elevator.
        /// </summary>
        /// <param name="floor">The floor number to which the elevator's destination is set.
        /// Floors are numbered from 0 (Ground floor) to 20.</param>
        /// <remarks>
        /// If the specified floor number is invalid (less than 0 or greater than 20),
        /// a message is displayed indicating the valid range. The elevator's destination is not changed.
        /// </remarks>
        public void SelectFloor(int floor)
        {
            if (floor < 0 || floor > 20)
            {
                Console.WriteLine("Invalid floor number. Please enter a floor between  0 (Ground floor) and 20.");
                return;
            }

            Console.WriteLine($"Destination floor selected: {floor}.");
            destinationFloorNumber = floor;
            Move();
        }


        /// <summary>
        /// Moves the elevator to its destination floor.
        /// </summary>
        /// <remarks>
        /// If the current floor number is the same as the destination floor number,
        /// a message indicating the current floor is displayed, and no further action is taken.
        /// Otherwise, a message indicating the elevator's movement from the current floor to the destination floor is displayed,
        /// and the elevator's current floor number is updated to the destination floor number.
        /// </remarks>
        private void Move()
        {
            if (currentFloorNumber == destinationFloorNumber)
            {
                Console.WriteLine($"Elevator is currently on floor number: {currentFloorNumber}.");
                return;
            }

            Console.WriteLine($"Elevator is moving from floor {currentFloorNumber} to floor {destinationFloorNumber}.");
            currentFloorNumber = destinationFloorNumber;
        }

    }
}
