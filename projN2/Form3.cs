using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projN2
{
    public partial class frm_manutencao : Form
    {
        public frm_manutencao()
        {
            InitializeComponent();
        }


        private void btn_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_serial.Text == string.Empty || txb_prob_descr.Text == string.Empty || txb_nome_tecnico.Text == string.Empty || txb_observacoes.Text == string.Empty || txb_valido.Text == string.Empty || cbb_usuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Serial está em branco.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                    conexao.Open();
                    SqlCommand instrucao = new SqlCommand(string.Format("INSERT INTO manutencoes (cod_equip, cod_usuario, descricao_falha, data_abertura, data_fechamento, observacoes, aprovador, valido) VALUES ((select cod_equip from equipamento where serial_number='{0}'),{1},'{2}','{3}','{4}','{5}','{6}','{7}')",
                                                        txb_serial.Text,
                                                        cbb_usuario.SelectedValue,
                                                        txb_prob_descr.Text,
                                                        dateTime_abertura.Text,//Value.ToString("yyyy-MM-dd"),
                                                        dateTime_fechamento.Text,//Value.ToString("yyyy-MM-dd"),
                                                        txb_observacoes.Text,
                                                        txb_nome_tecnico.Text,
                                                        txb_valido.Text), conexao);
                    instrucao.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Registro realizado com sucesso!", "Sucesso.", MessageBoxButtons.OK);
                    txb_serial.Text = "";
                    cbb_usuario.SelectedIndex = -1;
                    txb_prob_descr.Text = "";
                    txb_observacoes.Text = "";
                    txb_nome_tecnico.Text = "";
                    txb_valido.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_confirma_Click_1(object sender, EventArgs e)
        {

        }

        private void cbb_usuario_DropDown(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_usuario = new SqlDataAdapter(@"select usuarios.cod_usuario as 'codUsuario', usuarios.nome as 'Nome' from usuarios", conexao);
                DataTable tabela = new DataTable();
                cnst_usuario.Fill(tabela);
                conexao.Close();
                cbb_usuario.DataSource = tabela;
                cbb_usuario.DisplayMember = "Nome";
                cbb_usuario.ValueMember = "codUsuario";
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_manutencao_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirma_Click_2(object sender, EventArgs e)
        {

        }
    }
}
