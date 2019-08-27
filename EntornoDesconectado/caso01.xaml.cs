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
using System.Windows.Shapes;

namespace EntornoDesconectado
{
    /// <summary>
    /// Lógica de interacción para caso01.xaml
    /// </summary>
    public partial class caso01 : Window
    {
        ClsDatos obj = new ClsDatos();
        public caso01()
        {
            InitializeComponent();
        }

        private void CboAnios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            cboAnio.ItemsSource = obj.ListarPaises();
        }
    }
}
