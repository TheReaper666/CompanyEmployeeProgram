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
        // fix when you select a gender.
        public UCUpdate(Employee SelectedEmployee)
        {
            InitializeComponent();
            InsertIntoBoxes(SelectedEmployee);
        }
        public UCUpdate(bool EditMode, Employee SelectedEmployee)
        {
            InitializeComponent();
            if (EditMode == true)
            {
                textFirstName.IsReadOnly = false;
                textLastName.IsReadOnly = false;
                textTitleOfCourtesy.IsReadOnly = false;
                textTitle.IsReadOnly = false;
                DPHireDate.IsEnabled = true;
                textSex.IsReadOnly = false;
                textPosition.IsReadOnly = false;
                textSex.AllowDrop = true;
                InsertIntoBoxes(SelectedEmployee);
            }
        }

        public void InsertIntoBoxes(Employee SelectedEmployee)
        {
            textFirstName.Text = SelectedEmployee.FirstName;
            textLastName.Text = SelectedEmployee.LastName;
            textTitleOfCourtesy.Text = SelectedEmployee.TitleOfCourtesy;
            textTitle.Text = SelectedEmployee.Title;
            DPHireDate.SelectedDate = SelectedEmployee.HireDate;
            if (SelectedEmployee.Sex == "Male")
            {
                textSex.SelectedIndex = 0;
            }
            else if (SelectedEmployee.Sex == "Female")
            {
                textSex.SelectedIndex = 1;
            }
            textPosition.Text = SelectedEmployee.Position;
            textIsHourlyPaided.IsChecked = SelectedEmployee.IsHourlyPaided;
        }
    }
}
