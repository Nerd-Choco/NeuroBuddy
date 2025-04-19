using NeuroBuddy.Interfaces.Model;
using NeuroBuddy.Model;
using NeuroBuddy.Model.Enums;
using System.Xml.Serialization;


// Shaer:
// if you want to use this, it should be calculated from the time value (eg: 14:02 => Afternoon),
// but certainly not a saved value (look below)

public class Schedule
{
     public DateTime StartTime {get; set;}
     public DateTime EndTime {get; set;}
     public DateTime? LastStartTime { get; private set; }
     public TimeSpan ElapsedTime { get; private set; }
     public TimeSpan Duration => EndTime - StartTime; // Shaer: same as {get {return EndTime - StartTime;}}
     public bool IsPaused => LastStartTime == null;
     public bool IsLogged { get; private set; }
     public bool IsRecurring { get; set; }


    // Shaer:
    public PeriodOfDay PeriodOfDay
    {
        get
        {
             var StartHour = StartTime.Hour;
      
            if (StartHour >= 4 && StartHour < 6) return PeriodOfDay.Dwan;
            if (StartHour >= 6 && StartHour < 12) return PeriodOfDay.Morning;
            if (StartHour >= 12 && StartHour < 14) return PeriodOfDay.Noon;
            if (StartHour >= 14 && StartHour < 17) return PeriodOfDay.Afternoon;
            if (StartHour >= 17 && StartHour < 19) return PeriodOfDay.Sunset;
            if (StartHour >= 19 && StartHour < 22) return PeriodOfDay.Evening;

            return PeriodOfDay.Night;
        }
    }
    // Shaer: why do we need a note for this function LOL
    public void SetDuration(TimeSpan activityDuration)
    {
        EndTime = StartTime + activityDuration;
    }
     public void Start()
    {
        if(IsPaused)
            LastStartTime = DateTime.Now;
    }
    public void Pause()
    {
        if(!IsPaused && LastStartTime.HasValue)
        {
            ElapsedTime += DateTime.Now - LastStartTime.Value;
            LastStartTime = null;
        }
    }
    public void Postpone(TimeSpan DelayValue)
    {
        StartTime += DelayValue;
        EndTime += DelayValue;
    }
    public void Reschedule(DateTime newStartTime)
    {
        //Choco
       
        if (newStartTime < DateTime.Now)
            throw new Exception("you must log ");

        StartTime = newStartTime;
        EndTime = newStartTime + Duration;
    }
   
    public void Log(DateTime startedAt, DateTime endedAt)
    {
        //in the UI it must prevent the user from setting logged activity in the future. 
        if (endedAt > DateTime.Now || startedAt> DateTime.Now)
            throw new Exception("Can't log something in the future.");

        IsLogged = true;

        StartTime = startedAt;
        EndTime = endedAt;
        LastStartTime = null;
    }

    public TimeSpan GetTotalElapsedTime()
    {
        if (LastStartTime.HasValue)
        {
            return ElapsedTime + (DateTime.Now - LastStartTime.Value);
        }

        return ElapsedTime;
    }
    public NeuroStatus GetCurrentStatus()
    {
        if (ElapsedTime == TimeSpan.Zero && LastStartTime == null && DateTime.Now < StartTime)
            return NeuroStatus.NotStarted;

        if (GetTotalElapsedTime() >= Duration||IsLogged)
            return NeuroStatus.Complete;

        if (DateTime.Now >= EndTime && GetTotalElapsedTime() < Duration)
            return NeuroStatus.Incomplete;

         return NeuroStatus.InProgress;
    }

}