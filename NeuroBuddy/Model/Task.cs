using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model
{
    class Task
    {
        public Task()
        {
            
        }

        public Task(string name, Category category, double length, string[] notes)
        {
            Name = name;
            Category = category;
            Length = length;
            Notes = notes; 
        }

       //properties 
        public string Name 
        {
            get { return Name; }
            set { Name = value; } 
        }
        public Category Category 
        {
            get { return Category; }
            set { Category = value; }
        }
        public double Length
        {
            get { return Length; }
            set { Length = value; }
        }
        public string Tag
        {
            get { return Tag; }
            set { Tag = value; }
        }
        public string[] Notes
        {
            get { return Notes; }
            set { Notes = value; }
        }
       
        public string Date
        {
            get { return Date; }
            set { Date = value; }
        }
        //methods
        // i don't feel like this one is needed since we already have the parametrized constuctor
        // //if you don't see it necessary , remove 
        public void SetTask(Task NewTask)
        {
            this.Name = NewTask.Name;
            this.Category = NewTask.Category;
            this.Length = NewTask.Length;
            this.Notes = NewTask.Notes; 
        }
        public Task GetTask()
        {
            return this; 
        }

    }
}
