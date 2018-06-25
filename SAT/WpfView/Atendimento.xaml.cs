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
            if (rdoRegiao.Checked)
            {
                rdoRadio.Visible = Visible;
            }
            else
            {
                rdoRadio.Visible = false;
                .
            }
        }
    }
}
