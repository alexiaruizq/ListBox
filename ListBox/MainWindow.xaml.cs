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
using System.Collections.ObjectModel;
namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Color> Colores = new ObservableCollection<Color>();
        public MainWindow()
        {
            InitializeComponent();
            Colores.Add(new Color("Rojo","#FF000","(255,0,0)"));
            Colores.Add(new Color("Verde", "#F00F0", "(250,0,0)"));
            Colores.Add(new Color("Azul", "#00FF0", "(265,25,0)"));

            lstColores.ItemsSource = Colores;
        }

        private void BtnNuevoColor_Click(object sender, RoutedEventArgs e)
        {
            Colores.Add(new Color(txtNombre.Text,txtHexa.Text,txtRGB.Text)) ;
            txtNombre.Text = "";
            txtHexa.Text = "";
            txtRGB.Text = "";

            //Colores.Add();
            //txtColor.Text = "";
           
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(lstColores.SelectedIndex != -1)
            {
                Colores.RemoveAt(lstColores.SelectedIndex);
            }
        }

        private void lstColores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstColores.SelectedIndex !=-1)
            {
                txtNombreEditar.Text = Colores[lstColores.SelectedIndex].Nombre;
                txtHexaEditar.Text = Colores[lstColores.SelectedIndex].Hexadecimal;
                txtRGBEditar.Text = Colores[lstColores.SelectedIndex].RGB;
            }
            
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                Colores[lstColores.SelectedIndex].Nombre = txtNombreEditar.Text;
                Colores[lstColores.SelectedIndex].Hexadecimal = txtHexaEditar.Text;
                Colores[lstColores.SelectedIndex].RGB = txtRGBEditar.Text;

            }

            lstColores.Items.Refresh();
        }
    }
}
