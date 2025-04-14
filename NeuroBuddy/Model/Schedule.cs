using NeuroBuddy.Model;
using System.Xml.Serialization;

public enum PeriodOfDay
{
    Dwan,
    Morning,
    Afternoon,
    Noon,
    Sunset,
    Evening,
    Night
} 
// Shaer:
// if you want to use this, it should be calculated from the time value (eg: 14:02 => Afternoon),
// but certainly not a saved value (look below)

//Choco : some updates on the schedule class.. i had this idea, how too set the status of the activity,
// like in the phone add what happens is that you set a scheduled activity  and then a reminder would ring on the activity time
// in the reminder there is options to start the activity or delay, if it started is clicked it should start the activity and start the countdown..
// you can pause, resume or delay the activity so i created all of this in the scheudle because i thought it should be the main class handling time 

public class Schedule
{
     public DateTime StartTime {get; set;}
     public DateTime EndTime {get; set;}
     public DateTime? LastStartTime { get; private set; }
     public TimeSpan ElapsedTime { get; private set; }
     public TimeSpan Duration => EndTime - StartTime; // Shaer: same as {get {return EndTime - StartTime;}}
     public bool IsPaused => LastStartTime == null;
     


     // Shaer:
    public  PeriodOfDay PeriodOfDay
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

    //this function is to set a duration (like how many hours would it take)
    // you can set which period of the day so if you want to add a reminder, it can ring at that time.
    // or maybe we can create in the future list of tasks ,activities of each period of the day (would be cool actually) 
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
    public void Delay(TimeSpan DelayValue)
    {
        StartTime += DelayValue;
        EndTime += DelayValue;
    }
    public void Reschedule(DateTime newStartTime)
    {
     // how can we handle if someone reschedules an activity before the current time?
     // do we need a featrue like that? say I have scheduled workout before after work and ended up doing it in the break.
     // keep in mind that we have something called Logged activity, it will be a feature where you can log an activity /task that was already done

        StartTime = newStartTime;
        EndTime = newStartTime + Duration;
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

        if (GetTotalElapsedTime() >= Duration)
            return NeuroStatus.Complete;

        if (DateTime.Now >= EndTime && GetTotalElapsedTime() < Duration)
            return NeuroStatus.Incomplete;

         return NeuroStatus.InProgress;
    }

}