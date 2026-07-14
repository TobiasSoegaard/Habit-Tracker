using System;

namespace HabitTracker.Models;

public class Session
{
    public int Id { get; set; }
    
    public int HabitId { get; set; }
    
    public Habit? Habit { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
}