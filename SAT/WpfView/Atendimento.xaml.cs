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

namespace WpfView
{
    /// <summary>
    /// Lógica interna para Atendimento.xaml
    /// </summary>
    public partial class Atendimento : Window
    {
        public Atendimento()
        {
            InitializeComponent();
        }

        private void rdoRegiao_Checked(object sender, RoutedEventArgs e)
        {
            //Planos
            rdoRadio.Visibility = Visibility.Hidden;
            rdoFibra.Visibility = Visibility.Hidden;
            rdoCabeada.Visibility = Visibility.Hidden;
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            //Regiao
            rdoRegiao.IsChecked = false;
            rdoRadio.Visibility = Visibility.Visible;
            rdoFibra.Visibility = Visibility.Visible;
            rdoCabeada.Visibility = Visibility.Visible;
        }

        private void rdoRadio_Checked(object sender, RoutedEventArgs e)
        {
            cbCabos.Visibility = Visibility.Visible;
            cbDiscador.Visibility = Visibility.Visible;
            cbIsoladoCabo.Visibility = Visibility.Visible;
            cbReiniciadoPoe.Visibility = Visibility.Visible;
        }
    }
}
