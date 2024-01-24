using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Leitura_resistores_formulario
{
    public partial class Leitura_resistores : Form
    {
        public Leitura_resistores()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int fx1, fx2, fx3, fx4;
            fx1 = cbx_cor1.SelectedIndex;
            fx2 = cbx_cor2.SelectedIndex;
            fx3 = cbx_cor3.SelectedIndex;
            fx4 = cbx_cor4.SelectedIndex;
            lbl_resultado.Text = "Resultado:" + valor_resitor(fx1, fx2, fx3, fx4);

        }

        private void Leitura_resistores_Load(object sender, EventArgs e)
        {
            List<string> cores = new List<string>();
            cores.Add("PRETO");
            cores.Add("MARROM");
            cores.Add("VERMELHO");
            cores.Add("LARANJA");
            cores.Add("AMARELO");
            cores.Add("VERDE");
            cores.Add("AZUL");
            cores.Add("VIOLETA");
            cores.Add("CINZA");
            cores.Add("BRANCO");
            List<string> cores2 = new List<string>();
            cores2.Add("DOURADO");
            cores2.Add("PRATEADO");
            cbx_cor1.Items.AddRange(cores.ToArray());
            cbx_cor2.Items.AddRange(cores.ToArray());
            cbx_cor3.Items.AddRange(cores.ToArray());
            cbx_cor4.Items.AddRange(cores2.ToArray());
            cbx_cor1.SelectedIndex= 1;
            cbx_cor2.SelectedIndex= 0;
            cbx_cor3.SelectedIndex= 2;
            cbx_cor4.SelectedIndex= 0;
        }
        public string valor_resitor(int fx1, int fx2, int fx3, int fx4)
        {
            int resultado = 0;
            string tolerancia;

            resultado += (fx1) * 10;
            resultado += (fx2);
            resultado *= Convert.ToInt32(Math.Pow(10, (fx3)));
            if (fx4== 0)
            {
                tolerancia= "±5%";
            }
            else
            {
                tolerancia = "±10%";
            }
            return string.Format("{0} Ω {1}", resultado, tolerancia);
        }
        private string not_eng(double valor)
        {
            int[] expoentes = { 12, 9, 6, 3,};
            string[] simbolos = { "T", "G", "M", "K" };

        }
    }
}
