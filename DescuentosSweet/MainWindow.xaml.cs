using DescuentosSweet.Data;
using DescuentosSweet.Model.Local;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DescuentosSweet
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private TraspalmacenDal traspalmacen = new TraspalmacenDal();
        private VendedoresDal vendedoresDal = new VendedoresDal();
        public MainWindow()
        {
            InitializeComponent();
            DateTime start;
            DateTime end;
            start = DateTime.Now;
            end = DateTime.Now;
            try
            {
                dgTraspalmacen.ItemsSource = traspalmacen.GetTraspasoTRASPALMACEN(start, end);
            }
            catch (ConnectionFailedException)
            {
                MessageBox.Show("Problemas al Conectar a la base de Datos");
                frmMain.Close();
                Environment.Exit(0);

            }
            
            //;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            DateTime start;
            DateTime end;
            start = dpInicio.SelectedDate.Value;
            end = dpFin.SelectedDate.Value;
            
            dgTraspalmacen.ItemsSource = traspalmacen.GetTraspasoTRASPALMACEN(start, end);
            if(dgTraspalmacen.AlternationCount >= 0)
            {
                MessageBox.Show("No se han recuperado registros con la busqueda seleccionada.", "No existen registros.");
            }

        }
    }
}
