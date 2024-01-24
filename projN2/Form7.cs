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
    public partial class frm_list_mnt_equip : Form
    {
        public frm_list_mnt_equip()
        {
            InitializeComponent();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_list_equip = new SqlDataAdapter(@"select equipamento.serial_number as 'N° Serial', usuarios.nome as 'Abriu a mantçao', descricao_falha as 'Descrição da Falha', data_abertura as 'Data de Abertura', data_fechamento as 'Data de fechamento',aprovador as 'Fez a mntção',observacoes as 'Obs', valido as 'Válido' from manutencoes
                                                                inner join usuarios on manutencoes.cod_usuario = usuarios.cod_usuario
                                                                inner join equipamento on manutencoes.cod_equip = equipamento.cod_equip", conexao);
                DataTable tabela = new DataTable();
                cnst_list_equip.Fill(tabela);
                conexao.Close();
                listView1.Items.Clear(); //retirar os registros antigos do listview
                foreach (DataRow registro in tabela.Rows)
                {
                    ListViewItem item = new ListViewItem(registro[0].ToString());
                    item.SubItems.Add(registro[1].ToString());
                    item.SubItems.Add(registro[2].ToString());
                    item.SubItems.Add(registro[3].ToString());
                    item.SubItems.Add(registro[4].ToString());
                    item.SubItems.Add(registro[5].ToString());
                    item.SubItems.Add(registro[6].ToString());
                    item.SubItems.Add(registro[7].ToString());
                    listView1.Items.Add(item);
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
