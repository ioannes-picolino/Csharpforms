namespace projN2
{
    partial class frm_principal
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
            this.tlp_equip = new System.Windows.Forms.TableLayoutPanel();
            this.btn_lista_verif = new System.Windows.Forms.Button();
            this.btn_list_mnt = new System.Windows.Forms.Button();
            this.btn_verificacao = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn__lista_equip = new System.Windows.Forms.Button();
            this.btn_manutencao = new System.Windows.Forms.Button();
            this.lbl_conferencia_equip = new System.Windows.Forms.Label();
            this.tlp_equip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_equip
            // 
            this.tlp_equip.ColumnCount = 4;
            this.tlp_equip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_equip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_equip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_equip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_equip.Controls.Add(this.btn_lista_verif, 0, 4);
            this.tlp_equip.Controls.Add(this.btn_list_mnt, 0, 4);
            this.tlp_equip.Controls.Add(this.btn_verificacao, 0, 3);
            this.tlp_equip.Controls.Add(this.btn_adicionar, 1, 3);
            this.tlp_equip.Controls.Add(this.btn__lista_equip, 2, 3);
            this.tlp_equip.Controls.Add(this.btn_manutencao, 3, 3);
            this.tlp_equip.Controls.Add(this.lbl_conferencia_equip, 1, 0);
            this.tlp_equip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_equip.Location = new System.Drawing.Point(0, 0);
            this.tlp_equip.Name = "tlp_equip";
            this.tlp_equip.RowCount = 5;
            this.tlp_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_equip.Size = new System.Drawing.Size(800, 450);
            this.tlp_equip.TabIndex = 0;
            // 
            // btn_lista_verif
            // 
            this.btn_lista_verif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_lista_verif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lista_verif.Location = new System.Drawing.Point(3, 349);
            this.btn_lista_verif.Name = "btn_lista_verif";
            this.btn_lista_verif.Size = new System.Drawing.Size(194, 98);
            this.btn_lista_verif.TabIndex = 9;
            this.btn_lista_verif.Text = "LISTAGEM DE VERIFICAÇÕES";
            this.btn_lista_verif.UseVisualStyleBackColor = true;
            this.btn_lista_verif.Click += new System.EventHandler(this.btn_lista_verif_Click);
            // 
            // btn_list_mnt
            // 
            this.btn_list_mnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_list_mnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list_mnt.Location = new System.Drawing.Point(203, 349);
            this.btn_list_mnt.Name = "btn_list_mnt";
            this.btn_list_mnt.Size = new System.Drawing.Size(194, 98);
            this.btn_list_mnt.TabIndex = 8;
            this.btn_list_mnt.Text = "LISTAGEM DE MANUTENÇÕES";
            this.btn_list_mnt.UseVisualStyleBackColor = true;
            this.btn_list_mnt.Click += new System.EventHandler(this.btn_list_mnt_Click);
            // 
            // btn_verificacao
            // 
            this.btn_verificacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_verificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificacao.Location = new System.Drawing.Point(3, 247);
            this.btn_verificacao.Name = "btn_verificacao";
            this.btn_verificacao.Size = new System.Drawing.Size(194, 96);
            this.btn_verificacao.TabIndex = 0;
            this.btn_verificacao.Text = "VERIFICAÇÃO";
            this.btn_verificacao.UseVisualStyleBackColor = true;
            this.btn_verificacao.Click += new System.EventHandler(this.btn_verificacao_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(203, 247);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(194, 96);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "ADICIONAR NOVO";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn__lista_equip
            // 
            this.btn__lista_equip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn__lista_equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__lista_equip.Location = new System.Drawing.Point(403, 247);
            this.btn__lista_equip.Name = "btn__lista_equip";
            this.btn__lista_equip.Size = new System.Drawing.Size(194, 96);
            this.btn__lista_equip.TabIndex = 2;
            this.btn__lista_equip.Text = "MANUTENÇÃO";
            this.btn__lista_equip.UseVisualStyleBackColor = true;
            this.btn__lista_equip.Click += new System.EventHandler(this.btn__lista_equip_Click);
            // 
            // btn_manutencao
            // 
            this.btn_manutencao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_manutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manutencao.Location = new System.Drawing.Point(603, 247);
            this.btn_manutencao.Name = "btn_manutencao";
            this.btn_manutencao.Size = new System.Drawing.Size(194, 96);
            this.btn_manutencao.TabIndex = 3;
            this.btn_manutencao.Text = "LISTA DE EQUIPAMENTOS";
            this.btn_manutencao.UseVisualStyleBackColor = true;
            this.btn_manutencao.Click += new System.EventHandler(this.btn_manutencao_Click);
            // 
            // lbl_conferencia_equip
            // 
            this.lbl_conferencia_equip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_conferencia_equip.AutoSize = true;
            this.tlp_equip.SetColumnSpan(this.lbl_conferencia_equip, 2);
            this.lbl_conferencia_equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conferencia_equip.Location = new System.Drawing.Point(203, 7);
            this.lbl_conferencia_equip.Name = "lbl_conferencia_equip";
            this.lbl_conferencia_equip.Size = new System.Drawing.Size(394, 25);
            this.lbl_conferencia_equip.TabIndex = 4;
            this.lbl_conferencia_equip.Text = "CONFERÊNCIA DE EQUIPAMENTOS";
            this.lbl_conferencia_equip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_equip);
            this.Name = "frm_principal";
            this.Text = "Menu";
            this.tlp_equip.ResumeLayout(false);
            this.tlp_equip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_equip;
        private System.Windows.Forms.Button btn_verificacao;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn__lista_equip;
        private System.Windows.Forms.Button btn_manutencao;
        private System.Windows.Forms.Label lbl_conferencia_equip;
        private System.Windows.Forms.Button btn_list_mnt;
        private System.Windows.Forms.Button btn_lista_verif;
    }
}

