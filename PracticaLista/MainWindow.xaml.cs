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

namespace PracticaLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alumno> alumno = new List<Alumno>();

        public MainWindow()
        {
            InitializeComponent();
            alumno.Add(new Alumno("jose perez", "123456", "IPM"));
            alumno.Add(new Alumno("Sofia Belmar", "179420", "IIC"));
            alumno.Add(new Alumno("Andres Sanchez", "179911", "IPM"));
            alumno.Add(new Alumno("Sebas Nieblas", "179149", "IPM"));

            foreach(Alumno alumno in alumno)
            {
                ListBox.Items.Add(new 
                ListBoxItem()
                {
                    Content = alumno.Nombre
                }
                );

            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblNombre.Text = "Elemento Seleccionado" + ListBox.SelectedIndex.ToString();
            lblMatricula.Text = "Nuevo texto";
            lblCarrera.Text = "Nuevo Texto";
        }
    }
}
