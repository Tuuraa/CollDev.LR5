using System.Collections.ObjectModel;
using System.Windows;

namespace CollDev
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

    }

    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Sullary { get; set; }
        public int Id { get; set; }

    }

    class Sio
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public int Sullary { get; set; }
        public int Id { get; set; }

    }

    /// <summary>
    /// Логика взаимодействия для StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        private ObservableCollection<Person> People;
        private ObservableCollection<Teacher> Teacher;
        private ObservableCollection<Sio> Sio;

        public StudentWindow()
        {
            InitializeComponent();

            DefaultContext();
        }

        void DefaultContext()
        {
            People = new ObservableCollection<Person>
            {
                new Person { Id = 1, FirstName = "Иван", LastName = "Иванов" },
                new Person { Id = 2, FirstName = "Мария", LastName = "Петрова" },
                new Person { Id = 3, FirstName = "Петр", LastName = "Сидоров" }
            };
            dataGrid.ItemsSource = People;
        }
        void TeacherContext()
        {
            Teacher = new ObservableCollection<Teacher>
            {
                new Teacher { Id = 1, FirstName = "Анна", LastName = "Смирнова", Sullary = 50000 },
                new Teacher { Id = 2, FirstName = "Сергей", LastName = "Васильев", Sullary = 55000 },
                new Teacher { Id = 3, FirstName = "Ольга", LastName = "Михайлова", Sullary = 60000 }
            };

            dataGrid.ItemsSource = Teacher;
        }

        void SioContext()
        {
            Sio = new ObservableCollection<Sio>
            {
                new Sio { Id = 1, FirstName = "Алексей", LastName = "Кузнецов", Type = "Manager", Sullary = 70000 },
                new Sio { Id = 2, FirstName = "Виктория", LastName = "Крылова", Type = "Administrator", Sullary = 72000 },
                new Sio { Id = 3, FirstName = "Дмитрий", LastName = "Морозов", Type = "Director", Sullary = 75000 }
            };
            dataGrid.ItemsSource = Sio;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DefaultContext();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            SioContext();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            TeacherContext();
        }
    }
}
