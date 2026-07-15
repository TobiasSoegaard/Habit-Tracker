using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using HabitTracker.Services;

namespace HabitTracker.ViewModels;

public class HabitViewModel
{
    public string? Name1 { get; set; } = "Jeff Bezos";

    public List<string> names { get; } = ["Mark", "Mahmud"];


}