using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model
{
    enum States
    {
        NotStarted,
        InProgress,
        Incomplete,
        Complete,
    }
    class NeuroTask
    {
        string name = string.Empty;
        Category category;
        string tag = string.Empty;
        string notes = string.Empty;
        bool isRepeated = false;
        States states;
        public NeuroTask()
        {
            
        }

        public NeuroTask(string name, Category category, string notes, States states)
        {
            this.name = name;
            this.category = category;
            this.notes = notes;
            this.states = states;
        }

       //properties 
        public string Name
        {
            get { return name; }

            set => name = value;
        }
        public string Category 
        {
            get { return category; }
            set { category = value; }
        }
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        public States States 
        {
            get { return states; }
            set { states = value; }
        }
      
        //methods
        public void SetTask(NeuroTask NewTask)
        {
            this.Name = NewTask.Name;
            this.Category = NewTask.Category;
            this.Notes = NewTask.Notes;
            this.States = NewTask.States;
        }
      
        public NeuroTask GetTask()
        {
            return this; 
        }

    }
}
