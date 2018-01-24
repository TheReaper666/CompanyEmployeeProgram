using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Entities;

namespace Gui
{
    /// <summary>
    /// Interaction logic for UCUpdate.xaml
    /// </summary>
    public partial class UCUpdate : UserControl
    {
        public List<string> EmployeePositions;
        TabItem TabUpdate;
        Employee SelectedEmployee;
        public UCUpdate(Employee SelectedEmployee, TabItem TabUpdate, List<string> EmployeePositions)
        {
            InitializeComponent();
            this.EmployeePositions = EmployeePositions;
            ComboBoxPosition.ItemsSource = EmployeePositions;
            this.TabUpdate = TabUpdate;
            this.SelectedEmployee = SelectedEmployee;
            textFirstName.Text = SelectedEmployee.FirstName;
            textLastName.Text = SelectedEmployee.LastName;
            textTitleOfCourtesy.Text = SelectedEmployee.TitleOfCourtesy;
            textTitle.Text = SelectedEmployee.Title;
            DPHireDate.SelectedDate = SelectedEmployee.HireDate;
            checksex();
            checkhour();
            ComboBoxPosition.SelectedItem = SelectedEmployee.Position;
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            textFirstName.IsReadOnly = false;
            textLastName.IsReadOnly = false;
            textTitleOfCourtesy.IsReadOnly = false;
            textTitle.IsReadOnly = false;
            DPHireDate.IsEnabled = true;
            btnEdit.Visibility = Visibility.Hidden;
            btnUpdate.Visibility = Visibility.Visible;
            checksex();
            checkhour();
            TabUpdate.Header = "Update Employee";
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
        public void checksex()
        {
            if (SelectedEmployee.Sex == "Mand")
            {
                RadioSexFalse.IsChecked = false;
                RadioSexTrue.IsChecked = true;
            }
            else if (SelectedEmployee.Sex == "Kvinde")
            {
                RadioSexTrue.IsChecked = false;
                RadioSexFalse.IsChecked = true;
            }
        }
        public void checkhour()
        {
            bool Bool = SelectedEmployee.IsHourlyPaided;
            if (Bool == true)
            {
                RadioTimeFalse.IsChecked = false;
                RadioTimeTrue.IsChecked = true;
            }
            else
            {
                RadioTimeTrue.IsChecked = false;
                RadioTimeFalse.IsChecked = true;
            }
        }
    }
}