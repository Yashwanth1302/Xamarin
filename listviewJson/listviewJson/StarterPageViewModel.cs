using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listviewJson
{
    class StarterPageViewModel : INotifyPropertyChanged
    {
        List<StudentModel> studentlist;
        public List<StudentModel> Studentlist
        {
            get { return studentlist; }
            set
            {
                if (studentlist != value)
                {
                    studentlist = value;
                    OnPropertyChanged("indentMast");
                }
            }
        }

        public StarterPageViewModel()
        {
            studentlist = new List<StudentModel>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
