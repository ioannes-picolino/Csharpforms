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

namespace projN2
{
    public partial class frm_verif : Form
    {
        public frm_verif()
        {
            InitializeComponent();
        }

        private void frm_verif_Load(object sender, EventArgs e)
        {
            txb_serial.Focus();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection("Data source=LOCALHOST; Initial catalog=projN2; User ID=sa; Password=123456");
                conexao.Open();
                foreach (ListViewItem registro in LV_exibirVerif.Items)//ou pode ser listviewitem
                {
                    //MessageBox.Show(registro.Text, registro.SubItems[1].Text);
                    SqlCommand instrucao = new SqlCommand(string.Format("INSERT INTO verificacao_equip (cod_equip, data_verificacao) VALUES ((select cod_equip from equipamento where serial_number='{0}'),'{1}')",
                                                            registro.Text,
                                                            registro.SubItems[1].Text), conexao);
                    instrucao.ExecuteNonQuery();
                }

                conexao.Close();
                MessageBox.Show("Registro realizado com sucesso!", "Sucesso.", MessageBoxButtons.OK);
                txb_serial.Text = "";
                LV_exibirVerif.Clear();
            }
            catch
            {
                MessageBox.Show("Conexão não realizada, verifique os parâmetros.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txb_serial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_serial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ListViewItem item = new ListViewItem(txb_serial.Text);
                item.SubItems.Add(DateTime.Now.ToString());
                LV_exibirVerif.Items.Add(item);
                txb_serial.Clear();
            }

            txb_serial.Focus();
        }
    }
}
