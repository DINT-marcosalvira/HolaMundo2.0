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

namespace HolaMundo2._0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NombreTextBox.Text.Length > 0)
            {
                NombreTextBlock.Text = "Hola " + NombreTextBox.Text;
            }
            else
            {
                NombreTextBlock.Text = "Hola mundo!";
            }
        }

        private void NombreBotonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            NombreTextBox.Text = "";
            NombreTextBlock.Text = "Hola mundo!";
        }
    }
}
