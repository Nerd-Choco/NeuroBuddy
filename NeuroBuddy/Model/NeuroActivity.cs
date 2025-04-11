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
        //fields
        string _name;
        Category _category;
        Schedule _schedule;
        bool _isRepeated;
        NeuroTaskStatus _states;
        string _note;

        public string name
        {
            get { return _name; }
            set => _name = value;
        }
        public Category category
        {
            get { return _category; }
            set => _category = value;
        }
       public Schedule schedule
        {
            get { return schedule; }
            set => schedule = value;

        }
        
      public  NeuroActivity(string name, Category category)
        {
            this.name = name;
            this.category = category;
            this._states = NeuroTaskStatus.NotStarted;
        }
        public bool IsLogged()
        {
            return _states == NeuroTaskStatus.Complete;
        }


    }
}
