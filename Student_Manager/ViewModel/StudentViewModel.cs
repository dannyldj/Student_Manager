using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Student_Manager.Model;

namespace Student_Manager.ViewModel
{
    public class StudentViewModel : BindableBase
    {
        private Student _inputStudent = new Student();

        public Student InputStudent
        {
            get { return _inputStudent; }
            set { _inputStudent = value; }
        }

        public DelegateCommand AddCommand { get; set; }

        public ObservableCollection<Student> Students { get; set; }

        public StudentViewModel()
        {
            AddCommand = new DelegateCommand(OnAdd, CanAdd);
            Students = new ObservableCollection<Student>();
        }

        private void OnAdd()
        {
            if (string.IsNullOrEmpty(_inputStudent.SName) || string.IsNullOrEmpty(_inputStudent.Department))
                return;

            Students.Add(new Student() { SName = _inputStudent.SName, Department = _inputStudent.Department });
        }

        private bool CanAdd()
        {
            return _inputStudent != null;
        }
    }
}
