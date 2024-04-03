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
using UP_laba_4.ds.UP_laba_1DataSetTableAdapters;

namespace UP_laba_4.ds
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            MinWidth = 300;
            MinHeight = 400;
        }

        private void ships_show_Click(object sender, RoutedEventArgs e)
        {
            ShipTable ship = new ShipTable();
            ship.ShowDialog();
        }

        private void types_show_Click(object sender, RoutedEventArgs e)
        {
            TypeTable type = new TypeTable();
            type.ShowDialog();
        }

        private void pilots_show_Click(object sender, RoutedEventArgs e)
        {
            PilotsTable pilot = new PilotsTable();
            pilot.ShowDialog();
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
