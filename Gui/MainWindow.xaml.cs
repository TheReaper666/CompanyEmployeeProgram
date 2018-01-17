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
using Bizz;
using Entities;

namespace Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BizzFunctions BF = new BizzFunctions();
        ObservableCollection<Employee> OCEmployees;
        UCCreate UCC;
        UCUpdate UCU;
        public MainWindow()
        {
            InitializeComponent();
            OCEmployees = BF.GetAllEmployees();
            DataGridEmployees.DataContext = OCEmployees;
            DataGridEmployees.UnselectAll();
            TabController.SelectedIndex = 0;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Close Application?", "Quit?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void TCSelectionchanged(object sender, SelectionChangedEventArgs e)
        {
            TabControl tc = sender as TabControl;
            if (tc != null)
            {
                if (tc.SelectedItem == Tabcreate)
                {
                    UCCreateContent.Content = UCC;
                    btnUpdate.Visibility = Visibility.Hidden;
                    btnCreate.Visibility = Visibility.Visible;
                    btnEdit.Visibility = Visibility.Hidden;
                    DataGridEmployees.UnselectAll();
                    TabController.SelectedIndex = 0;
                }
                if (tc.SelectedItem == TabUpdate)
                {
                    if (DataGridEmployees.SelectedItem != null)
                    {
                        UCUpdateContent.Content = UCU = new UCUpdate();
                        btnCreate.Visibility = Visibility.Hidden;
                        btnEdit.Visibility = Visibility.Visible;
                        btnUpdate.Visibility = Visibility.Hidden;
                        TabController.SelectedIndex = 1;
                    }
                    else if (DataGridEmployees.SelectedItem == null)
                    {
                        MessageBox.Show("\tYou cant update anything,\nwhen you havent selected an item from the list","Warning!");
                        TabController.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
