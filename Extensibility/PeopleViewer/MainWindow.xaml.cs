using System.Collections.Generic;
using PersonRepository.Interface;
using System.Windows;
using PersonRepository.Factory;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ServiceFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("ServiceRepository");
        }

        private void CSVFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("CSVRepository");
        }

        private void SQLFetchButton_Click(object sender, RoutedEventArgs e)
        {
            PopulateListBox("SqlRepository");
        }

        private void PopulateListBox(string repositoryType)
        {
            IPersonRepository repository = RepositoryFactory.GetRepository(repositoryType);
            ClearListBox();
            IEnumerable<Person> persons = repository.GetPeople();
            foreach (var people in persons)
            {
                PersonListBox.Items.Add(people);
            }

            ShowRepositoryType(repository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
            RepositoryTypeTextBlock.Text = string.Empty;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            RepositoryTypeTextBlock.Text = repository.GetType().ToString();
        }
    }
}
