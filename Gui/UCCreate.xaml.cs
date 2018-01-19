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

        private void ComboBoxPosition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string testOfValue = e.ToString();
        }
    }
}
