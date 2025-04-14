using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model
{
    public enum NeuroStatus
    {
        NotStarted,
        Started,
        InProgress,
        Paused,
        Incomplete,
        Complete,
    }

    public class NeuroTask
    {
        //properties 
        public string Name { get; set; }

        public Category? Category { get; set; }

        public string Note { get; set; }

        public NeuroStatus Status { get; set; }

        public NeuroTask ()
        {
            Name = "";
            Category = null;
            Note = "";
            Status = NeuroStatus.NotStarted;
        }

        public NeuroTask(string Name, Category Category, string Notes, NeuroStatus Status)
        {
            this.Name = Name;
            this.Category = Category;
            this.Note = Notes;
            this.Status = Status;
        }

    }
}
