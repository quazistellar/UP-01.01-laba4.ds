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
    /// Логика взаимодействия для PilotsTable.xaml
    /// </summary>
    public partial class PilotsTable : Window
    {
        PilotsOfShipTableAdapter pilot = new PilotsOfShipTableAdapter();
        public PilotsTable()
        {
            InitializeComponent();

            MinWidth = 300;
            MinHeight = 320;

            DataContext = this;

            dgrid.ItemsSource = pilot.GetData();

            filter_cbx.ItemsSource = pilot.GetData();
            filter_cbx.DisplayMemberPath = "NamePilot";
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {
            dgrid.ItemsSource = pilot.SearchByNamePilot(search_tbx.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dgrid.ItemsSource = pilot.GetData();
            filter_cbx.Text = "";
            search_tbx.Text = string.Empty;
        }

        private void filter_cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (filter_cbx.SelectedItem != null)
            {
                var id = (int)(filter_cbx.SelectedItem as DataRowView).Row[0];

                dgrid.ItemsSource = pilot.FilterBy(id);
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
