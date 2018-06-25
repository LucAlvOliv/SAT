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
            //Visibilidade CheckBox
            //radio
            cbCabos.Visibility = Visibility.Hidden;
            cbDiscador.Visibility = Visibility.Hidden;
            cbIsoladoCabo.Visibility = Visibility.Hidden;
            cbReiniciadoPoe.Visibility = Visibility.Hidden;

        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            //Checked
            //regiao
            rdoRegiao.IsChecked = false;
            //planos
            rdoRadio.IsChecked = false;
            rdoFibra.IsChecked = false;
            rdoCabeada.IsChecked = false;
            //radio
            cbReiniciadoPoe.IsChecked = false;
            cbIsoladoCabo.IsChecked = false;
            cbDiscador.IsChecked = false;
            cbCabos.IsChecked = false;
            //fibra
            cbONU.IsChecked = false;
            cbRompimento.IsChecked = false;
            //cabeada
            cbRoteador.IsChecked = false;

            //Visibilidade Geral
            //radio
            cbCabos.Visibility = Visibility.Hidden;
            cbDiscador.Visibility = Visibility.Hidden;
            cbIsoladoCabo.Visibility = Visibility.Hidden;
            cbReiniciadoPoe.Visibility = Visibility.Hidden;
            //fibra
            cbONU.Visibility = Visibility.Hidden;
            cbRompimento.Visibility = Visibility.Hidden;
            //cabeada
            cbRoteador.Visibility = Visibility.Hidden;
        }

        private void rdoRadio_Checked(object sender, RoutedEventArgs e)
        {
            //Visibilidade para os botoes dessa tecnologia
            cbCabos.Visibility = Visibility.Visible;
            cbDiscador.Visibility = Visibility.Visible;
            cbIsoladoCabo.Visibility = Visibility.Visible;
            cbReiniciadoPoe.Visibility = Visibility.Visible;

            //Visibilidade Outros
            //fibra
            cbONU.Visibility = Visibility.Hidden;
            cbRompimento.Visibility = Visibility.Hidden;
            //cabeada
            cbRoteador.Visibility = Visibility.Hidden;
        }

        private void rdoFibra_Checked(object sender, RoutedEventArgs e)
        {
            //Visibilidade para os botoes dessa tecnologia
            cbCabos.Visibility = Visibility.Visible;
            cbDiscador.Visibility = Visibility.Visible;
            cbONU.Visibility = Visibility.Visible;
            cbRompimento.Visibility = Visibility.Visible;

            //Visibilidade Outros
            //radio
            cbIsoladoCabo.Visibility = Visibility.Hidden;
            cbReiniciadoPoe.Visibility = Visibility.Hidden;
            //cabeada
            cbRoteador.Visibility = Visibility.Hidden;
        }

        private void rdoCabeada_Checked(object sender, RoutedEventArgs e)
        {
            //Visibilidade para os botoes dessa tecnologia
            cbCabos.Visibility = Visibility.Visible;
            cbDiscador.Visibility = Visibility.Visible;
            cbIsoladoCabo.Visibility = Visibility.Visible;
            cbRoteador.Visibility = Visibility.Visible;

            //Visibilidade Outros
            //radio
            cbReiniciadoPoe.Visibility = Visibility.Hidden;
            //fibra
            cbONU.Visibility = Visibility.Hidden;
            cbRompimento.Visibility = Visibility.Hidden;
        }
    }
}
