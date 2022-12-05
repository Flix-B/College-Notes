using PeopleLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary.ViewModels
{
    internal class MainViewModel
    {
		#region properties
		private ObservableCollection<Person> _people;

		public ObservableCollection<Person> People
		{
			get { return _people; }
			//set { _people = value; }
		}
        #endregion
        #region methods
		public void addPerson(string firstname, string surname, int age)
		{
			Person person = new Person();
			person.FirstName = firstname;
			person.Surname = surname;
			person.Age = age;
			_people.Add(person);
		}

		public string printPeople()
		{
			string people = string.Empty;
			foreach (Person person in _people) 
			{
				people += $"{person.FirstName} {person.Surname} (age = {person.Age})"; 
			}
			return people;
		}
        #endregion
    }
}