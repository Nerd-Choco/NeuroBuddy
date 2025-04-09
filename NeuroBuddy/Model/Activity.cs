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
    class Activity
    {
        //fields
        string name;
        Category category;
        Schedule schedule;
        bool isRepeated;
        States states;
        string note;

      public  Activity() 
        {

        }
      public  Activity(string name, Category category)
        {
            this.name = name;
            this.category = category;
        }
        public bool IsLogged()
        {
            return states == States.Complete;
        }


    }
}
