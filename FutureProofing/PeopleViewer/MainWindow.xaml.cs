using Common;
using People.Library;
using System.Collections.Generic;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PersonRepository _repository = new PersonRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            List<Person> persons = _repository.GetPeople();
            PersonListBox.ItemsSource = persons;

        }

        private void AbstractFetchButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Person> persons = _repository.GetPeople();
            PersonListBox.ItemsSource = persons;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.ItemsSource = null;
        }
    }
}
