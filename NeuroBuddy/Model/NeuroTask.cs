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
        string category = string.Empty;
        double length = 0;
        string tag = string.Empty;
        string notes = string.Empty;
        string date = string.Empty;
        States states;
        public NeuroTask()
        {
            
        }

        public NeuroTask(string name, string category, double length, string notes, States states)
        {
            this.name = name;
            this.category = category;
            this.length = length;
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
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Tag
        {
            get { return tag; }
            set { tag= value; }
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
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        //methods
        public void SetTask(NeuroTask NewTask)
        {
            this.Name = NewTask.Name;
            this.Category = NewTask.Category;
            this.Length = NewTask.Length;
            this.Notes = NewTask.Notes;
            this.States = NewTask.States;
        }
        public NeuroTask GetTask()
        {
            return this; 
        }

    }
}
