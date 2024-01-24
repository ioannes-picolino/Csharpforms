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

namespace projN2
{
    public partial class Frm_adicionar_novo : Form
    {
        public Frm_adicionar_novo()
        {
            InitializeComponent();
        }

        private void cbb_marca_DropDown(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_marca = new SqlDataAdapter(@"select marcas.cod_marca as 'codMarca', marcas.descricao_marca as 'marca' from marcas", conexao);
                DataTable tabela = new DataTable();
                cnst_marca.Fill(tabela);
                conexao.Close();
                cbb_marca.DataSource = tabela;
                cbb_marca.DisplayMember = "marca";
                cbb_marca.ValueMember = "codMarca";
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_descr_DropDown(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_descEquip = new SqlDataAdapter(@"select descricoes_equip.cod_desc_equip as 'codDesc', descricoes_equip.descricao_equip as 'equip' from descricoes_equip", conexao);
                DataTable tabela = new DataTable();
                cnst_descEquip.Fill(tabela);
                conexao.Close();
                cbb_descr.DataSource = tabela;
                cbb_descr.DisplayMember = "equip";
                cbb_descr.ValueMember = "codDesc";
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_loc_DropDown(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_loc = new SqlDataAdapter(@"select locais.cod_locais as 'codLoc', locais.descricao_local as 'Local' from locais", conexao);
                DataTable tabela = new DataTable();
                cnst_loc.Fill(tabela);
                conexao.Close();
                cbb_loc.DataSource = tabela;
                cbb_loc.DisplayMember = "Local";
                cbb_loc.ValueMember = "codLoc";
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_novo_equip_Click(object sender, EventArgs e)
        {
            try
            {
                if(txb_serial.Text==string.Empty|| cbb_marca.SelectedIndex==-1|| cbb_descr.SelectedIndex == -1|| cbb_loc.SelectedIndex==-1)
                {
                    MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Serial está em branco.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                    conexao.Open();
                    SqlCommand instrucao = new SqlCommand(string.Format("INSERT INTO equipamento (serial_number, cod_marca, cod_desc_equip, cod_locais) VALUES ('{0}','{1}','{2}','{3}')",
                                                        txb_serial.Text,
                                                        cbb_marca.SelectedValue,
                                                        cbb_descr.SelectedValue,
                                                        cbb_loc.SelectedValue), conexao);
                    instrucao.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Registro realizado com sucesso!", "Sucesso.", MessageBoxButtons.OK);
                    txb_serial.Text = "";
                    cbb_marca.SelectedIndex = -1;
                    cbb_descr.SelectedIndex = -1;
                    cbb_loc.SelectedIndex = -1;
                }
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn(object sender, EventArgs e)
        {

        }
    }
}
