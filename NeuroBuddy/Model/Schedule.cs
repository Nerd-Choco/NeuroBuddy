enum PeriodOfDay
{
    Dwan,
    Morning,
    Afternoon,
    Noon,
    Sunset,
    Evening,
    Night
}

class Schedule
{
     DateTime startTime;
     DateTime endTime;
     TimeSpan Duration;
     PeriodOfDay periodOfDay;
    // I don't think we need to access the set publicly, getting them to maybe display them
    // or to categorize them based on the timeRange or period of time
    public DateTime StartTIme 
    {
        get { return startTime; }
    }
    public DateTime EndTime
    {
        get { return endTime; }
    }
    public PeriodOfDay Period 
    {
        get { return periodOfDay; }
    }

    public Schedule() { }
    //here you can set a time rand like from 11 to 12 etc.
    public void SetTimeRange(DateTime startTime, DateTime endTime)
    {
        this.startTime = startTime;
        this.endTime = endTime;
         Duration = endTime - startTime;
    }
    //this function is to set a duration (like how many hours would it take)
    // you can set which period of the day so if you want to add a reminder, it can ring at that time.
    // or maybe we can create in the future list of tasks ,activities of each period of the day (would be cool actually) 
    public void SetDuration(TimeSpan activityDuration,PeriodOfDay periodOfDay)
    {
        Duration = activityDuration;
        this.periodOfDay = periodOfDay;

    }
    public TimeSpan GetDuration()
    {
        return Duration.Duration(); 
    }

}
