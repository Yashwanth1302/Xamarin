using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listviewJson
{
    class StudentModel : INotifyPropertyChanged
    {
        string fullname;
        public string Birthday { get; set; }

        public string FullName
        {
            get { return fullname; }
            set
            {
                if (fullname != value)
                {
                    fullname = value;
                    OnPropertyChanged("FrLocCode");
                }
            }
        }

        public string Phonenumber { get; set; }

        public string ProfilePhoto { get; set; }

        public string RegistrationDate { get; set; }

        public string SecurityAnswer { get; set; }

        public string SecurityQuestion { get; set; }

        public string StudentGrade { get; set; }

        public string StudentId { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
