using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //namespace para manipular arquivos externos

namespace GUI_editor_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog janela_Salvamento = new SaveFileDialog();//mostra o local do arquivo para salvar
            janela_Salvamento.Filter = "Arquivo de texto(*.txt) | *.txt | Arquivo csv (*.csv) | *.csv";
            janela_Salvamento.FilterIndex = 1; //tipo do filtro padrao
            if (janela_Salvamento.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter arquivo = new StreamWriter(janela_Salvamento.FileName))
                    {
                    arquivo.Write(rtxtB_texto.Text);
                    //arquivo.Close();
                    }
                }
                catch 
                {
                    MessageBox.Show("O arquivo não foi salvo.\nRevise o enderço e nome do arquivo.", "Erro ao salvar");
                }
            }
            else
            {
                MessageBox.Show("O arquivo não foi salvo.\nRevise o enderço e nome do arquivo.", "Erro ao salvar");
            }



        }

        private void btn_abri_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela_Abri = new OpenFileDialog();
            janela_Abri.Filter = "Arquivo de texto(*.txt)| *.txt | Arquivo csv (*.csv) | *.csv | Todos os arquivos | *.*";
            if (janela_Abri.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    using (StreamReader arquivo = new StreamReader(janela_Abri.FileName))
                    {
                        rtxtB_texto.Text = arquivo.ReadToEnd();
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao ler o arquivo.\nVerifique a estrutura do arquivo.");
                }

            }
            else
            {
                MessageBox.Show("Operação cancelada!");
            }

        }
    }
}
