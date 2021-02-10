using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager.Model
{
    public class Student : BindableBase
    {
        //public int SIndex { get; set; }

        public string SName { get; set; }

        public string Department { get; set; }
    }
}
