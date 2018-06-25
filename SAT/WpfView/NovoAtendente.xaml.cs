using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using Utils;
using Controllers;
using Models;

namespace WpfView
{
    /// <summary>
    /// Lógica interna para NovoAtendente.xaml
    /// </summary>
    public partial class NovoAtendente : Window
    {
        public NovoAtendente()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, RoutedEventArgs e)
        {
            if(pswSenha.Password != pswConfirmarSenha.Password)
            {
                MessageBox.Show("Senha e confirmar senha não conferem!");
                return;
            }

            string senhaCriptografada = Criptografia.GerarCriptografia(pswSenha.Password);
            
            AtendenteController atendenteController = new AtendenteController();
            Atendente novo = new Atendente();
            novo.Usuario = txtUsuario.Text;
            string s = senhaCriptografada;
            novo.Senha = s;
            atendenteController.Adicionar(novo);
            MessageBox.Show("Criado com sucesso!");
        }


        
    }
}
