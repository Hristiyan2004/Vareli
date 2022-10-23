namespace DataAccess.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int ShiftId { get; set; }
        public int PositionId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }

    }
}