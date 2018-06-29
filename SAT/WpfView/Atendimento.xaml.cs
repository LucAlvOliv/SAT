using Controllers;
using Models;
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
            cbONU.Visibility = Visibility.Hidden;
            cbRoteador.Visibility = Visibility.Hidden;

        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            //Checked
            //soluçao
            rdoNaoSolucionado.IsChecked = false;
            rdoSolucionado.IsChecked = false;
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

            //Campos Geral
            txtNome.Clear();
            txtCpf.Clear();
            txtCodCliente.Clear();
            txtProtocolo.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtReferencia.Clear();
            txtPeriodo.Clear();
            txtDescricao.Clear();
            txtAtendimento.Clear();
            txtPlano.Clear();

            //Visibilidade de Solução
            //lbl
            lblDesc.Visibility = Visibility.Hidden;
            lblEnd.Visibility = Visibility.Hidden;
            lblPeri.Visibility = Visibility.Hidden;
            lblRef.Visibility = Visibility.Hidden;
            lblTel.Visibility = Visibility.Hidden;
            //txt
            txtDescricao.Visibility = Visibility.Hidden;
            txtEndereco.Visibility = Visibility.Hidden;
            txtPeriodo.Visibility = Visibility.Hidden;
            txtReferencia.Visibility = Visibility.Hidden;
            txtTelefone.Visibility = Visibility.Hidden;
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

        private void rdoSolucionado_Checked(object sender, RoutedEventArgs e)
        {
            //Clear
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtReferencia.Clear();
            txtPeriodo.Clear();
            txtDescricao.Clear();
            txtAtendimento.Clear();

            //Visibilidade Geral
            //lbl
            lblDesc.Visibility = Visibility.Hidden;
            lblEnd.Visibility = Visibility.Hidden;
            lblPeri.Visibility = Visibility.Hidden;
            lblRef.Visibility = Visibility.Hidden;
            lblTel.Visibility = Visibility.Hidden;
            //txt
            txtDescricao.Visibility = Visibility.Hidden;
            txtEndereco.Visibility = Visibility.Hidden;
            txtPeriodo.Visibility = Visibility.Hidden;
            txtReferencia.Visibility = Visibility.Hidden;
            txtTelefone.Visibility = Visibility.Hidden;
        }

        private void rdoNaoSolucionado_Checked(object sender, RoutedEventArgs e)
        {
            //Visibilidade Geral
            //lbl
            lblDesc.Visibility = Visibility.Visible;
            lblEnd.Visibility = Visibility.Visible;
            lblPeri.Visibility = Visibility.Visible;
            lblRef.Visibility = Visibility.Visible;
            lblTel.Visibility = Visibility.Visible;
            //txt
            txtDescricao.Visibility = Visibility.Visible;
            txtEndereco.Visibility = Visibility.Visible;
            txtPeriodo.Visibility = Visibility.Visible;
            txtReferencia.Visibility = Visibility.Visible;
            txtTelefone.Visibility = Visibility.Visible;
        }

        private void btnCriarCliente_Click(object sender, RoutedEventArgs e)
        {
            UsuariosController usuariosController = new UsuariosController();
            Usuario novo = new Usuario();
            novo.Nome = txtClienteNome.Text;
            novo.CPF = txtClienteCpf.Text;
            novo.Plano = txtClientePlano.Text;
            novo.CodCliente = txtClienteCod.Text;
            usuariosController.Adicionar(novo);
            MessageBox.Show("Criado com sucesso!");
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            //if (Aqui vai a comparaçao com o banco de dados para verificar se o cliente existe)
            //{
            //    MessageBox.Show("Cliente não esta cadastrado.");
            //}

            string nome = "Nome: " + txtNome.Text;
            string cpf = "CPF: " + txtCpf.Text;
            string codCliente = "Codigo do Cliente: " + txtCodCliente;
            string protocolo = "Protocolo: " + txtProtocolo.Text;
            string plano = "Plano: " + txtPlano.Text;
            string tipo;
            string cabos;
            string discador;
            string isolado;
            string onu;
            string poe;
            string rompimento;
            string roteador;
            string solucao;
            string endereco = "Endereço: " + txtEndereco;
            string telefone = "Telefone: " + txtTelefone;
            string referencia = "Referencia: " + txtReferencia;
            string periodo = "Periodo da visita: " + txtPeriodo;
            string descricao = "Descrição do problema: " + txtDescricao;

            //testes
            if (cbCabos.IsChecked == true)
            {
                cabos = "Cabos Verificados";
            }
            else
            {
                cabos = "";
            }

            if (cbDiscador.IsChecked == true)
            {
                discador = ",Criado Discador";
            }
            else
            {
                discador = "";
            }

            if (cbIsoladoCabo.IsChecked == true)
            {
                isolado = ",Cabo Isolado";
            }
            else
            {
                isolado = "";
            }

            if (cbONU.IsChecked == true)
            {
                onu = ",ONU Reiniciada";
            }
            else
            {
                onu = "";
            }

            if (cbReiniciadoPoe.IsChecked == true)
            {
                poe = ",POE Reiniciado";
            }
            else
            {
                poe = "";
            }

            if (cbRompimento.IsChecked == true)
            {
                rompimento = ",Possivel Rompimento";
            }
            else
            {
                rompimento = "";
            }

            if (cbRoteador.IsChecked == true)
            {
                roteador = ",Roteador Reiniciado";
            }
            else
            {
                roteador = "";
            }
            //tipo
            if (rdoRegiao.IsChecked == true)
            {
                tipo = "Existe um problema na região do cliente, por isso a falta de conexão";
            }
            else if (rdoRadio.IsChecked == true)
            {
                tipo = "Conexão via: Radio /n Testes realizados: " + cabos + poe + isolado + discador;
            }
            else if (rdoFibra.IsChecked == true)
            {
                tipo = "Conexão via: Fibra /n Testes realizados: " + cabos + onu + rompimento + discador;
            }
            else
            {
                tipo = "Conexão via: Cabo /n Testes realizados: " + cabos + roteador + isolado + discador;
            }
            //solucao
            if (rdoSolucionado.IsChecked == true)
            {
                solucao = "Solucionado: Sim";
            }
            else
            {
                solucao = "Solucionado: Não /nAgendamento /n" + endereco + telefone + referencia + periodo + descricao;
            }

            txtAtendimento.SelectedText = nome + cpf + codCliente + protocolo + plano + tipo + solucao;
            AtendimentoController atendimentoController = new AtendimentoController();
            AtendimentoCliente novoatendimento = new AtendimentoCliente();
            novoatendimento.Problema = txtAtendimento.Text;
            atendimentoController.Adicionar(novoatendimento);
        }
    }
}
