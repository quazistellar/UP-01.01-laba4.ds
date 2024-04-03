using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;
using UP_laba_4.ds.UP_laba_1DataSetTableAdapters;

namespace UP_laba_4.ds
{
    /// <summary>
    /// Логика взаимодействия для ShipTable.xaml
    /// </summary>
    public partial class ShipTable : Window
    {
        SpaceShipsTableAdapter ship = new SpaceShipsTableAdapter();
        public ShipTable()
        {
            InitializeComponent();

            MinWidth = 300;
            MinHeight = 320;

            DataContext = this;

            dgrid.ItemsSource = ship.GetData();

            filter_cbx.ItemsSource = ship.GetData();
            filter_cbx.DisplayMemberPath = "NameShip";
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {
            dgrid.ItemsSource = ship.SearchByNameShip(search_tbx.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            dgrid.ItemsSource = ship.GetData();
            filter_cbx.Text = "";
            search_tbx.Text = string.Empty;
 


        }

        private void filter_cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (filter_cbx.SelectedItem != null)
            {
                var id = (int)(filter_cbx.SelectedItem as DataRowView).Row[0];

                dgrid.ItemsSource = ship.FilterBy(id);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var window = GetWindow(this);

            if (window != null)
            {
                window.Close();
            }
        }
    }
}
