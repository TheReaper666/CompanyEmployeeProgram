using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for UCCreate.xaml
    /// </summary>
    public partial class UCCreate : UserControl
    {
        public List<string> EmployeePositions;
        public UCCreate(List<string> EmployeePositions)
        {
            InitializeComponent();
            this.EmployeePositions = EmployeePositions;
            ComboBoxPosition.ItemsSource = EmployeePositions;
        }
        public UCCreate(bool click)
        {
            InitializeComponent();
            string firstname = textFirstName.Text;
            string lastname = textLastName.Text;
            string titleofcourtesy = textTitleOfCourtesy.Text;
            string title = textTitle.Text;
            DateTime hiredate = textHireDate.DisplayDate;
            string sex = "";
            if (RBMale.IsChecked == true)
            {
                sex = "Mand";
            }
            else if (RBFemale.IsChecked == true)
            {
                sex = "Kvinde";
            }
            bool ishourly = true;
            if (RByes.IsChecked == true)
            {
                ishourly = true;
            }
            else if (RBno.IsChecked == true)
            {
                ishourly = false;
            }
            string position = ComboBoxPosition.SelectedItem.ToString();
            Employee newEmployee = new Employee(firstname, lastname, titleofcourtesy, title, position, ishourly,hiredate, sex);
        }

        private void ComboBoxPosition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string testOfValue = e.ToString();
        }
    }
}
