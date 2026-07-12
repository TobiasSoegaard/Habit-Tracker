using System;
using HabitTracker.Models;

namespace HabitTracker.Services;

public class TimerService
{
    Session session;

    public TimerService()
    {
        session = new Session();
        
        TimeSpan studyTime = session.EndTime - session.StartTime;
    }
}