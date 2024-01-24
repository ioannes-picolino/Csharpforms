using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace atividadeB2N2
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cbb_cli_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_cli_codCliente.Text = cbb_cli_nome.SelectedValue.ToString();
            lbl_cli_endereco.Text = cbb_cli_nome.SelectedItem.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbb_cli_nome_DropDown(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=avaliacaoB2N2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_clientes = new SqlDataAdapter("SELECT cod_cliente, nome, endereco FROM clientes", conexao);
                DataTable tabela = new DataTable();
                cnst_clientes.Fill(tabela);
                conexao.Close();
                cbb_cli_nome.DataSource = tabela;
                cbb_cli_nome.DisplayMember = "nome";
                cbb_cli_nome.ValueMember = "cod_cliente";
                //cbb_cli_nome.DisplayMember = "endereco";
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_carro_modelo_DropDown(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=avaliacaoB2N2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_carro = new SqlDataAdapter(@"select carros.registro, carros.modelo, clientes.nome from carros
                                                                inner join apolices on carros.cod_apolice=apolices.cod_apolice
                                                                inner join clientes on apolices.cliente=clientes.cod_cliente", conexao);
                DataTable tabela = new DataTable();
                cnst_carro.Fill(tabela);
                conexao.Close();
                cbb_carro_modelo.DataSource = tabela;
                cbb_carro_modelo.DisplayMember = "carros.modelo";
                cbb_carro_modelo.ValueMember = "carros.registro";
                cbb_carro_modelo.DisplayMember = "clientes.nome";
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_cli_endereco_Click(object sender, EventArgs e)
        {

        }

        private void cbb_carro_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_carro_codigo.Text = cbb_carro_modelo.SelectedValue.ToString();
            lbl_carro_cliente.Text = cbb_carro_modelo.SelectedItem.ToString();
        }

        private void btn_acid_novoAcidente_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=avaliacaoB2N2; User ID=sa; Password=123456");
                conexao.Open();
                SqlCommand instrucao = new SqlCommand(string.Format("INSERT INTO acidentes VALUES,{0},'{1}',{2})",
                                                                    cbb_acid_carro.SelectedItem,
                                                                    txt_acid_data.Text,
                                                                    txt_acid_local), conexao);
                instrucao.ExecuteNonQuery();
                conexao.Close();
            }
        }

        private void cbb_acid_carro_DropDown(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=avaliacaoB2N2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_carro = new SqlDataAdapter(@"select carros.registro, carros.modelo, clientes.nome from carros", conexao);
                DataTable tabela = new DataTable();
                cnst_carro.Fill(tabela);
                conexao.Close();
                cbb_acid_carro.DataSource = tabela;
                cbb_acid_carro.ValueMember = "carros.registro";
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
