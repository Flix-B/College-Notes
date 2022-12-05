using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary.Models
{
    internal class Person: BaseClass
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged();  }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; OnPropertyChanged(); }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged(); }
        }

    }
}
