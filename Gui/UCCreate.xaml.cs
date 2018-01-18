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
        public List<string> comboboxListItems = new List<string>();
        public UCCreate()
        {
            InitializeComponent();
            //comboboxListItems.Add("Mand");
            //comboboxListItems.Add("Kvinde");
            //textSex.ItemsSource = comboboxListItems;
        }

        private void textSex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string Selecteditem = sender as string;
            //textSex.DisplayMemberPath = (string)Selecteditem;
        }
    }
}
