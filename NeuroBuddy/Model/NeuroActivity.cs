using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NeuroBuddy.Model
{
    /*so basically we have scheduled activity and task,
     * one activity can have multiple tasks, a task can have a scheduled activity
     */
    class NeuroActivity
    {
        
        public string Name { set; get; }
        public Category? Category { set; get; }
        public string Description {set;get;}
        public Schedule Schedule { set; get; } = new Schedule();
        public NeuroStatus Status => Schedule.GetCurrentStatus();
        public TimeSpan Elapsed => Schedule.GetTotalElapsedTime();
        public PeriodOfDay Period => Schedule.PeriodOfDay;
        public string ? Note{ set; get; }
        public bool IsLoggedActivity => Schedule.IsLogged;


        public  NeuroActivity(string name, Category category,string description, DateTime StartTime,DateTime EndTime)
        {
            Name = name;
            Category = category;
            Description = description;
            Schedule.StartTime = StartTime;
            Schedule.EndTime = EndTime;
 
        }
        public NeuroActivity(string name, Category category, string description, DateTime StartTime, TimeSpan duration)
        {
            Name = name;
            Category = category;
            Description = description;
            Schedule.StartTime = StartTime;
            Schedule.SetDuration(duration);


        }
        public NeuroActivity()
        {
            Name = " ";
            Category = new Category();
            Description = " ";
            Schedule.StartTime =DateTime.Now;
            Schedule.EndTime = DateTime.Now;
        }
        public void LoggedActivity(DateTime StartTime, DateTime Endtime)
        {
            Schedule.Log(StartTime, Endtime);
        }
        public void Start()
        {
            Schedule.Start();
        }
        public void Pause()
        {
            Schedule.Pause();
        }
        public void DelayActivity(TimeSpan DelayValue)
        {
            Schedule.Delay(DelayValue);
        }
        public void RescheduleActivity(DateTime newStartTime)
        {
            Schedule.Reschedule(newStartTime);
        }

    }
}
