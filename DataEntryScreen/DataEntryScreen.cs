using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryScreen
{
    public partial class DataEntryScreen : Form
    {
        List<Person> People = new List<Person>();
        BindingSource source = new BindingSource();
        public DataEntryScreen()
        {
            InitializeComponent();

            LoadTestData();

            source.DataSource = People;
            PeopleDropdown.DataSource = source;

            PeopleDropdown.DisplayMember = "FullName";
            PeopleDropdown.ValueMember = "FullName";
        }

        private void LoadTestData()
        {
            People.Add(new Person { FirstName = "Tim", LastName = "Corey", Age = 35 });
            People.Add(new Person { FirstName = "Mary", LastName = "Jayne", Age = 21 });
            People.Add(new Person { FirstName = "Sue", LastName = "Breeze", Age = 29 });
            People.Add(new Person { FirstName = "Jon", LastName = "Dough", Age = 42 });

        }
        private void PeopleDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)PeopleDropdown_SelectedItem;
            SelectedAgeLabel.Text = selectedPerson.Age.ToString();
        }
        private void AddPerson_Click(object sender, EventArgs e)
        {
            int age = 0;
            int.TryParse(AgeField.Text, out age);

            Person createdPerson = new Person();
            createdPerson.FirstName = FirstNameField.Text;
            createdPerson.LastName = LastNameField.Text;
            createdPerson.Age = age;

            People.Add(createdPerson);

            source.ResetBindings(true);
        }

        
    }
}
