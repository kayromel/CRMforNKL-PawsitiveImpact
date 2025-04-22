public class Volunteer
{
    public int VolunteerID { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }

    public DateTime? CheckInTime { get; set; }
    public double TotalMinutes { get; set; }

}