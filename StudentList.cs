using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Student_Manager
{
    [Serializable]
    public class StudentItem : INotifyPropertyChanged
    {
        private XElement student;
        internal XElement Student { get { return student; } }
        internal StudentItem(XElement student)
        {
            this.student = student;
        }
        public string SName
        {
            get { return student.Element("sname").Value; }
            set
            {
                student.Element("sname").Value = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("sname"));
                }
            }
        }
        public string Department
        {
            get { return student.Element("department").Value; }
            set
            {
                student.Element("department").Value = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("department"));
                }
            }
        }

        public override string ToString()
        {
            string result;
            result = String.Format("Name : {0}  |  Department : {1}", SName, Department);
            return result;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    [Serializable]
    public class StudentList : INotifyPropertyChanged
    {
        [NonSerialized]
        private XDocument studentList;
        [NonSerialized]
        private List<StudentItem> items;

        public List<StudentItem> Items { get { return items; } }

        public StudentList()
        {
            string listFileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\temp\\studentlist.xml";
            if (File.Exists(listFileName))
            {
                studentList = XDocument.Load(listFileName);
                items = (from e in studentList.Root.Elements()
                         select new StudentItem(e)).ToList();
            }
            else
            {
                studentList = new XDocument();
                studentList.Add(new XElement("studentlist"));
                items = new List<StudentItem>();
            }
        }

        public void Additem(string sname, string department)
        {
            Random rand = new Random();
            XElement item = new XElement("student");
            XElement _sname = new XElement("sname");
            XElement depart = new XElement("department");
            _sname.Value = sname;
            item.Add(_sname);
            depart.Value = department;
            item.Add(depart);

            studentList.Root.Add(item);
            items.Add(new StudentItem(item));

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Items"));
            }
        }

        public void DeleteItem(StudentItem item)
        {
            items.Remove(item);
            item.Student.Remove();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Items"));
            }
        }

        public void Save()
        {
            string listFileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\temp\\studentlist.xml";
            studentList.Save(listFileName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
