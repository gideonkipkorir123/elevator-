public class Elevator
{
    public int Id { get; set; }
    public string SerialNumber { get; set; }
    public int CurrentFloor { get; set; }

    public Elevator(int id, string serialNumber, int currentFloor)
    {
        Id = id;
        SerialNumber = serialNumber;
        CurrentFloor = currentFloor;
    }
}
