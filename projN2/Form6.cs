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
    public partial class frm_list_verif_equip : Form
    {
        public frm_list_verif_equip()
        {
            InitializeComponent();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                conexao.Open();
                SqlDataAdapter cnst_list_equip = new SqlDataAdapter(@"select equipamento.serial_number as 'N° Serial', .verificacao_equip.data_verificacao as 'Data de Verificção' from verificacao_equip
                                                                inner join equipamento on verificacao_equip.cod_equip = equipamento.cod_equip", conexao);
                DataTable tabela = new DataTable();
                cnst_list_equip.Fill(tabela);
                conexao.Close();
                listView1.Items.Clear(); //retirar os registros antigos do listview
                foreach (DataRow registro in tabela.Rows)
                {
                    ListViewItem item = new ListViewItem(registro[0].ToString());
                    item.SubItems.Add(registro[1].ToString());
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
