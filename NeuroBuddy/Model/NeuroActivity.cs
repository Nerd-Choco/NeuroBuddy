using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model
{
    /*so basically we have scheduled activity and task,
     * one activity can have multiple tasks, a task can have a scheduled activity
     */
    class NeuroActivity
    {
        
        public string Name { set; get; }
        public Category? Category { set; get; }
        public Schedule Schedule { set; get; }
        public NeuroStatus Status { set; get; }
        public string ? Note{ set; get; }


        
      public  NeuroActivity(string name, Category category,Schedule schedule, NeuroStatus status)
        {
            Name = name;
            Category = category;
            Schedule = schedule;
            Status = status;
        }
        public NeuroActivity()
        {
            Name = " ";
            Status = NeuroStatus.NotStarted;
        }
        public bool IsLogged()
        {
            return Status == NeuroStatus.Complete;
        }
        public void Start()
        {

        }

        

    }
}
