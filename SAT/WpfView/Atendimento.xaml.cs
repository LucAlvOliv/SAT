﻿using Controllers;
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
    public partial class Atendimento : Window
    {
        Cliente clienteAtendimento;

        public Atendimento()
        {
            InitializeComponent();
        }

        private void PesquisarCliente()
        {
            ClientesController clientesController = new ClientesController();
            clienteAtendimento = clientesController.BuscarPorCpf(txtCpf.Text);
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

            //solução
            rdoNaoSolucionado.IsChecked = false;
            rdoSolucionado.IsChecked = false;

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
            ClientesController usuariosController = new ClientesController();
            Cliente novo = new Cliente();
            novo.Nome = txtClienteNome.Text;
            novo.CPF = txtClienteCpf.Text;
            novo.Plano = txtClientePlano.Text;
            novo.CodCliente = txtClienteCod.Text;
            usuariosController.Adicionar(novo);
            MessageBox.Show("Criado com sucesso!");
        }
                
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarDgClientes();
        }

        private void CarregarDgClientes()
        {
            ClientesController usuariosControllerCarregar = new ClientesController();
            dgClientes.ItemsSource = usuariosControllerCarregar.ListarTodos();
        }

        private void GridHistorico_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarDgAtendimentosRealizados();
        }

        private void CarregarDgAtendimentosRealizados()
        {
            AtendimentoController atendimentoControllerCarregar = new AtendimentoController();
            dgAtendimentosRealizados.ItemsSource = atendimentoControllerCarregar.ListarTodos();
        }

        private void btnConfirmar_Click_1(object sender, RoutedEventArgs e)
        {
            string nome = "Nome: " + txtNome.Text + "\n";
            string cpf = "CPF: " + txtCpf.Text + "\n";
            string codCliente = "Codigo do Cliente: " + txtCodCliente.Text + "\n";
            string protocolo = "Protocolo: " + txtProtocolo.Text + "\n";
            string plano = "Plano: " + txtPlano.Text + "\n";
            string tipo;
            string cabos;
            string discador;
            string isolado;
            string onu;
            string poe;
            string rompimento;
            string roteador;
            string solucao;
            string endereco = "Endereço: " + txtEndereco.Text + "\n";
            string telefone = "Telefone: " + txtTelefone.Text + "\n";
            string referencia = "Referencia: " + txtReferencia.Text + "\n";
            string periodo = "Periodo da visita: " + txtPeriodo.Text + "\n";
            string descricao = "Descrição do problema: " + txtDescricao.Text + "\n";

            //testes
            if (cbCabos.IsChecked == true)
            {
                cabos = " -Cabos Verificados" + "\n";
            }
            else
            {
                cabos = "";
            }

            if (cbDiscador.IsChecked == true)
            {
                discador = " -Criado Discador" + "\n";
            }
            else
            {
                discador = "";
            }

            if (cbIsoladoCabo.IsChecked == true)
            {
                isolado = " -Cabo Isolado" + "\n";
            }
            else
            {
                isolado = "";
            }

            if (cbONU.IsChecked == true)
            {
                onu = " -ONU Reiniciada" + "\n";
            }
            else
            {
                onu = "";
            }

            if (cbReiniciadoPoe.IsChecked == true)
            {
                poe = " -POE Reiniciado" + "\n";
            }
            else
            {
                poe = "";
            }

            if (cbRompimento.IsChecked == true)
            {
                rompimento = " -Possivel Rompimento" + "\n";
            }
            else
            {
                rompimento = "";
            }

            if (cbRoteador.IsChecked == true)
            {
                roteador = " -Roteador Reiniciado" + "\n";
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
                tipo = "Conexão via: Radio \nTestes realizados: \n" + cabos + poe + isolado + discador;
            }
            else if (rdoFibra.IsChecked == true)
            {
                tipo = "Conexão via: Fibra \nTestes realizados: \n" + cabos + onu + rompimento + discador;
            }
            else if (rdoCabeada.IsChecked == true)
            {
                tipo = "Conexão via: Cabo \nTestes realizados: \n" + cabos + roteador + isolado + discador;
            }
            else
            {
                tipo = "";
            }
            //solucao
            if (rdoSolucionado.IsChecked == true)
            {
                solucao = "Solucionado: Sim";
            }
            else if (rdoNaoSolucionado.IsChecked == true)
            {
                solucao = "Solucionado: Não \n\nAgendamento \n" + endereco + telefone + referencia + periodo + descricao;
            }
            else
            {
                solucao = "";
            }

            txtAtendimento.Text = nome + cpf + codCliente + protocolo + plano + tipo + solucao;

            AtendimentoController atendimentoController = new AtendimentoController();
            Models.Atendimento novoatendimento = new Models.Atendimento();
            novoatendimento.Problema = txtAtendimento.Text;
            novoatendimento.ClienteID = clienteAtendimento.ClienteID;
            atendimentoController.Adicionar(novoatendimento);
            MessageBox.Show("Atendimento salvo");
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnCompletar_Click(object sender, RoutedEventArgs e)
        {
            PesquisarCliente();
            if (clienteAtendimento.CPF == null)
            {
                //se nao encontar um cadastro com esse cpf, message box de que nao existe
                MessageBox.Show("CPF incorreto ou cliente não cadastrado");
            }
            else
            {
                //se encontrar, auto completar
                txtCpf.Text = clienteAtendimento.CPF;
                txtNome.Text = clienteAtendimento.Nome;
                txtPlano.Text = clienteAtendimento.Plano;
                txtCodCliente.Text = clienteAtendimento.CodCliente;
            }
        }

        private void Atendimento1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
