using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projN2
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Frm_adicionar_novo janela = new Frm_adicionar_novo();
            janela.ShowDialog();
        }

        private void btn_verificacao_Click(object sender, EventArgs e)
        {
            frm_verif janela = new frm_verif();
            janela.ShowDialog();
        }

        private void btn__lista_equip_Click(object sender, EventArgs e)
        {
            frm_manutencao janela = new frm_manutencao();
            janela.ShowDialog();
        }

        private void btn_manutencao_Click(object sender, EventArgs e)
        {
            frm_list_equip janela= new frm_list_equip();
            janela.ShowDialog();
        }

        private void btn_lista_verif_Click(object sender, EventArgs e)
        {
            frm_list_verif_equip janela = new frm_list_verif_equip();
            janela.ShowDialog();
        }

        private void btn_list_mnt_Click(object sender, EventArgs e)
        {
            frm_list_mnt_equip janela = new frm_list_mnt_equip();
            janela.ShowDialog();
        }
    }
}
