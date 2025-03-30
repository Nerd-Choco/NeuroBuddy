using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Presenter
{
    class TaskManagerPresenter
    {
        //model
        TaskManagerInterface Model;
        // view
        TaskMangerView View; 
        TaskManagerPresenter(TaskMangerView view)
        {
            this.View = view;
            Model= new TaskManager();
        }
        

    }
}
