﻿using System;
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

namespace WpfView
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ___btnNovo__Click(object sender, RoutedEventArgs e)
        {
            NovoAtendente novoAtendente = new NovoAtendente();

            novoAtendente.Show();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            Atendimento atendimento = new Atendimento();

            atendimento.Show();
        }
    }
}
