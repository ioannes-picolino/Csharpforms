
namespace atividadeB2N2
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_cli_endereco = new System.Windows.Forms.Label();
            this.lbl_cli_codCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_cli_nome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_acid_local = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_acid_carro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_acid_data = new System.Windows.Forms.TextBox();
            this.btn_acid_novoAcidente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_carro_cliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_carro_codigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_carro_modelo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 273);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_cli_endereco);
            this.groupBox1.Controls.Add(this.lbl_cli_codCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbb_cli_nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de clientes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_cli_endereco
            // 
            this.lbl_cli_endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_cli_endereco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_cli_endereco.Location = new System.Drawing.Point(3, 97);
            this.lbl_cli_endereco.Name = "lbl_cli_endereco";
            this.lbl_cli_endereco.Size = new System.Drawing.Size(252, 30);
            this.lbl_cli_endereco.TabIndex = 5;
            this.lbl_cli_endereco.Text = "---";
            this.lbl_cli_endereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cli_endereco.Click += new System.EventHandler(this.lbl_cli_endereco_Click);
            // 
            // lbl_cli_codCliente
            // 
            this.lbl_cli_codCliente.Location = new System.Drawing.Point(163, 58);
            this.lbl_cli_codCliente.Name = "lbl_cli_codCliente";
            this.lbl_cli_codCliente.Size = new System.Drawing.Size(89, 13);
            this.lbl_cli_codCliente.TabIndex = 4;
            this.lbl_cli_codCliente.Text = "---";
            this.lbl_cli_codCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Endereço cadastrado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Código do cliente";
            // 
            // cbb_cli_nome
            // 
            this.cbb_cli_nome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_cli_nome.FormattingEnabled = true;
            this.cbb_cli_nome.Location = new System.Drawing.Point(59, 23);
            this.cbb_cli_nome.Name = "cbb_cli_nome";
            this.cbb_cli_nome.Size = new System.Drawing.Size(193, 21);
            this.cbb_cli_nome.TabIndex = 1;
            this.cbb_cli_nome.DropDown += new System.EventHandler(this.cbb_cli_nome_DropDown);
            this.cbb_cli_nome.SelectedIndexChanged += new System.EventHandler(this.cbb_cli_nome_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_acid_local);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbb_acid_carro);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_acid_data);
            this.groupBox3.Controls.Add(this.btn_acid_novoAcidente);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 131);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar acidente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Local do acidente";
            // 
            // txt_acid_local
            // 
            this.txt_acid_local.Location = new System.Drawing.Point(104, 81);
            this.txt_acid_local.Name = "txt_acid_local";
            this.txt_acid_local.Size = new System.Drawing.Size(415, 20);
            this.txt_acid_local.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data do acidente";
            // 
            // cbb_acid_carro
            // 
            this.cbb_acid_carro.FormattingEnabled = true;
            this.cbb_acid_carro.Location = new System.Drawing.Point(104, 25);
            this.cbb_acid_carro.Name = "cbb_acid_carro";
            this.cbb_acid_carro.Size = new System.Drawing.Size(154, 21);
            this.cbb_acid_carro.TabIndex = 2;
            this.cbb_acid_carro.DropDown += new System.EventHandler(this.cbb_acid_carro_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carro";
            // 
            // txt_acid_data
            // 
            this.txt_acid_data.Location = new System.Drawing.Point(104, 55);
            this.txt_acid_data.Name = "txt_acid_data";
            this.txt_acid_data.Size = new System.Drawing.Size(415, 20);
            this.txt_acid_data.TabIndex = 3;
            // 
            // btn_acid_novoAcidente
            // 
            this.btn_acid_novoAcidente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_acid_novoAcidente.Location = new System.Drawing.Point(3, 105);
            this.btn_acid_novoAcidente.Name = "btn_acid_novoAcidente";
            this.btn_acid_novoAcidente.Size = new System.Drawing.Size(516, 23);
            this.btn_acid_novoAcidente.TabIndex = 3;
            this.btn_acid_novoAcidente.Text = "Registrar";
            this.btn_acid_novoAcidente.UseVisualStyleBackColor = true;
            this.btn_acid_novoAcidente.Click += new System.EventHandler(this.btn_acid_novoAcidente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_carro_cliente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_carro_codigo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbb_carro_modelo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(267, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de carros";
            // 
            // lbl_carro_cliente
            // 
            this.lbl_carro_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_carro_cliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_carro_cliente.Location = new System.Drawing.Point(3, 97);
            this.lbl_carro_cliente.Name = "lbl_carro_cliente";
            this.lbl_carro_cliente.Size = new System.Drawing.Size(252, 30);
            this.lbl_carro_cliente.TabIndex = 10;
            this.lbl_carro_cliente.Text = "---";
            this.lbl_carro_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nome do cliente correspondente";
            // 
            // lbl_carro_codigo
            // 
            this.lbl_carro_codigo.Location = new System.Drawing.Point(162, 59);
            this.lbl_carro_codigo.Name = "lbl_carro_codigo";
            this.lbl_carro_codigo.Size = new System.Drawing.Size(89, 13);
            this.lbl_carro_codigo.TabIndex = 8;
            this.lbl_carro_codigo.Text = "---";
            this.lbl_carro_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Código do automóvel";
            // 
            // cbb_carro_modelo
            // 
            this.cbb_carro_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_carro_modelo.FormattingEnabled = true;
            this.cbb_carro_modelo.Location = new System.Drawing.Point(56, 23);
            this.cbb_carro_modelo.Name = "cbb_carro_modelo";
            this.cbb_carro_modelo.Size = new System.Drawing.Size(193, 21);
            this.cbb_carro_modelo.TabIndex = 6;
            this.cbb_carro_modelo.DropDown += new System.EventHandler(this.cbb_carro_modelo_DropDown);
            this.cbb_carro_modelo.SelectedIndexChanged += new System.EventHandler(this.cbb_carro_modelo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carro";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TelaPrincipal";
            this.Text = "Seguradora";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_cli_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_acid_carro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_acid_data;
        private System.Windows.Forms.Button btn_acid_novoAcidente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cli_endereco;
        private System.Windows.Forms.Label lbl_cli_codCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_acid_local;
        private System.Windows.Forms.Label lbl_carro_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_carro_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_carro_modelo;
    }
}

