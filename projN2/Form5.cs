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
    public partial class frm_list_equip : Form
    {
        public frm_list_equip()
        {
            InitializeComponent();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_list_equip = new SqlDataAdapter(@"select equipamento.serial_number as 'N° Serial', marcas.descricao_marca as 'Marca', descricoes_equip.descricao_equip as 'Descrição do Aparelho', locais.descricao_local as 'Local' from equipamento
                                                                inner join marcas on equipamento.cod_marca = marcas.cod_marca
                                                                inner join descricoes_equip on equipamento.cod_desc_equip = descricoes_equip.cod_desc_equip
                                                                inner join locais on equipamento.cod_locais = locais.cod_locais", conexao);
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
                    listView1.Items.Add(item);
                }
             
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
