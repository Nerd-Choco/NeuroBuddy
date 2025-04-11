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

public class Schedule
{
     public DateTime StartTime {get; set;}

     public DateTime EndTime {get; set;}

     public TimeSpan Duration => EndTime - StartTime; // Shaer: same as {get {return EndTime - StartTime;}}


     // Shaer:
     //PeriodOfDay PeriodOfDay
     //{
        //get
        //{
            // calculate it and return it here
        //}
     //}

    
    
    // Shaer: why do we need a note for this function LOL

    //this function is to set a duration (like how many hours would it take)
    // you can set which period of the day so if you want to add a reminder, it can ring at that time.
    // or maybe we can create in the future list of tasks ,activities of each period of the day (would be cool actually) 
    public void SetDuration(TimeSpan activityDuration)
    {
        EndTime = StartTime + activityDuration;
    }

}
