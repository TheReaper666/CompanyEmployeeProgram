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
                RadioSexFalse.IsChecked = false;
                RadioSexTrue.IsChecked = false;
                RadioTimeFalse.IsChecked = false;
                RadioTimeTrue.IsChecked = false;
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
            if (SelectedEmployee.Sex == "1")
            {
                RadioSexFalse.IsChecked = false;
                RadioSexTrue.IsChecked = true;
            }
            else if (SelectedEmployee.Sex == "0")
            {
                RadioSexTrue.IsChecked = false;
                RadioSexFalse.IsChecked = true;
            }

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
