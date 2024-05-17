using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageCell : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public ImageCell()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee
            {
                DisplayName = "Arceus",
                Position = "Top",
                Image = "https://archives.bulbagarden.net/media/upload/9/9e/0493Arceus.png"
            });

            employees.Add(new Employee
            {
                DisplayName = "Giratina",
                Position = "Matter",
                Image = "https://archives.bulbagarden.net/media/upload/b/b7/0484Palkia.png"
            });

            employees.Add(new Employee
            {
                DisplayName = "Palkia",
                Position = "Space",
                Image = "https://archives.bulbagarden.net/media/upload/8/81/0487Giratina.png"
            });

            employees.Add(new Employee
            {
                DisplayName = "Dialga",
                Position = "Time",
                Image = "https://archives.bulbagarden.net/media/upload/4/43/0483Dialga.png"
            });

            employees.Add(new Employee
            {
                DisplayName = "Snom",
                Position = "Chad",
                Image = "https://archives.bulbagarden.net/media/upload/8/84/0872Snom.png"
            });
        }
    }
}