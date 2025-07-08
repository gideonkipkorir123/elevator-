
class Program
{
    static void Main(string[] args)
    {
        int floor1 = ReadIntFromConsole("Enter current floor of Elevator 1:");
        int floor2 = ReadIntFromConsole("Enter current floor of Elevator 2:");
        int floor3 = ReadIntFromConsole("Enter current floor of Elevator 3:");
        int requestedFloor = ReadIntFromConsole("Enter the floor where you want to summon an elevator:");

        List<Elevator> elevators = new List<Elevator>
        {
            new Elevator(1, "ELEVETOR-001", floor1),
            new Elevator(2, "ELEVETOR-002", floor2),
            new Elevator(3, "ELEVETOR-003", floor3)
        };

        string chosenElevatorSerial = SummonElevator(elevators, requestedFloor);
        Console.WriteLine($"The most efficient elevator is: {chosenElevatorSerial}");
    }

    static int ReadIntFromConsole(string prompt)
    {
        int value;
        while (true)
        {
            Console.WriteLine(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out value))
                break;
            else
                Console.WriteLine("Invalid number. Please try again.");
        }
        return value;
    }

    static string SummonElevator(List<Elevator> elevators, int requestedFloor)
    {
        Elevator bestElevator = elevators
            .OrderBy(e => Math.Abs(e.CurrentFloor - requestedFloor)) // closest
            .ThenBy(e => e.Id) // tie-breaker: lowest Id
            .First();

        return bestElevator.SerialNumber;
    }
}
