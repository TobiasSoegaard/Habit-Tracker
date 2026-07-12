using System.Collections.Generic;

namespace HabitTracker.Models;

public class Habit
{
    public int Id { get; set; }
    
    public string Name { get; set; } = "";

    public List<Session> Sessions { get; set; } = [];
    
    public string Color { get; set; } = "";
    
    public int GoalMinutesPerDay { get; set; }
}