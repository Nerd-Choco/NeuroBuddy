namespace NeuroBuddy.Core;

public abstract class NeuroSchedule
{
    //public NeuroReminder? Reminder {get; set;}
}

public class NeuroScheduleStartEnd : NeuroSchedule
{
    public DateTime Start {get; set;}

    public DateTime End {get; set;}

    public TimeSpan Duration => End - Start;
}

public class NeuroScheduleDurationOnly : NeuroSchedule
{
    public TimeSpan Duration {get; set;}
}