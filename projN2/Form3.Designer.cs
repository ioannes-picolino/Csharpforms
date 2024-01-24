namespace projN2
{
    partial class frm_manutencao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_manutencao = new System.Windows.Forms.TableLayoutPanel();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.lbl_equip = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_manutencao = new System.Windows.Forms.Label();
            this.txb_serial = new System.Windows.Forms.TextBox();
            this.txb_prob_descr = new System.Windows.Forms.TextBox();
            this.dateTime_abertura = new System.Windows.Forms.DateTimePicker();
            this.lbl_aprovador = new System.Windows.Forms.Label();
            this.txb_nome_tecnico = new System.Windows.Forms.TextBox();
            this.lbl_abreProcesso = new System.Windows.Forms.Label();
            this.cbb_usuario = new System.Windows.Forms.ComboBox();
            this.lbl_fecha_manutencao = new System.Windows.Forms.Label();
            this.dateTime_fechamento = new System.Windows.Forms.DateTimePicker();
            this.lbl_observacoes = new System.Windows.Forms.Label();
            this.txb_observacoes = new System.Windows.Forms.TextBox();
            this.lbl_valido = new System.Windows.Forms.Label();
            this.txb_valido = new System.Windows.Forms.TextBox();
            this.tlp_manutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_manutencao
            // 
            this.tlp_manutencao.ColumnCount = 2;
            this.tlp_manutencao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_manutencao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_manutencao.Controls.Add(this.btn_confirma, 0, 8);
            this.tlp_manutencao.Controls.Add(this.lbl_equip, 0, 0);
            this.tlp_manutencao.Controls.Add(this.lbl_descricao, 0, 1);
            this.tlp_manutencao.Controls.Add(this.lbl_manutencao, 0, 2);
            this.tlp_manutencao.Controls.Add(this.txb_serial, 1, 0);
            this.tlp_manutencao.Controls.Add(this.txb_prob_descr, 1, 1);
            this.tlp_manutencao.Controls.Add(this.dateTime_abertura, 1, 2);
            this.tlp_manutencao.Controls.Add(this.lbl_aprovador, 0, 5);
            this.tlp_manutencao.Controls.Add(this.txb_nome_tecnico, 1, 5);
            this.tlp_manutencao.Controls.Add(this.lbl_abreProcesso, 0, 4);
            this.tlp_manutencao.Controls.Add(this.cbb_usuario, 1, 4);
            this.tlp_manutencao.Controls.Add(this.lbl_fecha_manutencao, 0, 3);
            this.tlp_manutencao.Controls.Add(this.dateTime_fechamento, 1, 3);
            this.tlp_manutencao.Controls.Add(this.lbl_observacoes, 0, 6);
            this.tlp_manutencao.Controls.Add(this.txb_observacoes, 1, 6);
            this.tlp_manutencao.Controls.Add(this.lbl_valido, 0, 7);
            this.tlp_manutencao.Controls.Add(this.txb_valido, 1, 7);
            this.tlp_manutencao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_manutencao.Location = new System.Drawing.Point(0, 0);
            this.tlp_manutencao.Name = "tlp_manutencao";
            this.tlp_manutencao.RowCount = 9;
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_manutencao.Size = new System.Drawing.Size(572, 526);
            this.tlp_manutencao.TabIndex = 0;
            // 
            // btn_confirma
            // 
            this.btn_confirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirma.Location = new System.Drawing.Point(3, 467);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(280, 56);
            this.btn_confirma.TabIndex = 15;
            this.btn_confirma.Text = "CONFIRMA";
            this.btn_confirma.UseVisualStyleBackColor = true;
            this.btn_confirma.Click += new System.EventHandler(this.btn_confirma_Click);
            // 
            // lbl_equip
            // 
            this.lbl_equip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_equip.AutoSize = true;
            this.lbl_equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equip.Location = new System.Drawing.Point(3, 4);
            this.lbl_equip.Name = "lbl_equip";
            this.lbl_equip.Size = new System.Drawing.Size(280, 50);
            this.lbl_equip.TabIndex = 0;
            this.lbl_equip.Text = "Escreva o serial do equipamento.";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.Location = new System.Drawing.Point(3, 74);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(280, 25);
            this.lbl_descricao.TabIndex = 1;
            this.lbl_descricao.Text = "Descreva o problema.";
            // 
            // lbl_manutencao
            // 
            this.lbl_manutencao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_manutencao.AutoSize = true;
            this.lbl_manutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manutencao.Location = new System.Drawing.Point(3, 132);
            this.lbl_manutencao.Name = "lbl_manutencao";
            this.lbl_manutencao.Size = new System.Drawing.Size(280, 25);
            this.lbl_manutencao.TabIndex = 2;
            this.lbl_manutencao.Text = "Data da manutenção.";
            // 
            // txb_serial
            // 
            this.txb_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_serial.Location = new System.Drawing.Point(289, 13);
            this.txb_serial.Name = "txb_serial";
            this.txb_serial.Size = new System.Drawing.Size(280, 31);
            this.txb_serial.TabIndex = 6;
            // 
            // txb_prob_descr
            // 
            this.txb_prob_descr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_prob_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_prob_descr.Location = new System.Drawing.Point(289, 71);
            this.txb_prob_descr.Name = "txb_prob_descr";
            this.txb_prob_descr.Size = new System.Drawing.Size(280, 31);
            this.txb_prob_descr.TabIndex = 7;
            // 
            // dateTime_abertura
            // 
            this.dateTime_abertura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_abertura.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_abertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_abertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_abertura.Location = new System.Drawing.Point(289, 129);
            this.dateTime_abertura.Name = "dateTime_abertura";
            this.dateTime_abertura.Size = new System.Drawing.Size(280, 31);
            this.dateTime_abertura.TabIndex = 8;
            // 
            // lbl_aprovador
            // 
            this.lbl_aprovador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_aprovador.AutoSize = true;
            this.lbl_aprovador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aprovador.Location = new System.Drawing.Point(3, 294);
            this.lbl_aprovador.Name = "lbl_aprovador";
            this.lbl_aprovador.Size = new System.Drawing.Size(280, 50);
            this.lbl_aprovador.TabIndex = 3;
            this.lbl_aprovador.Text = "Quem está realizando a manutenção?";
            // 
            // txb_nome_tecnico
            // 
            this.txb_nome_tecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_nome_tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nome_tecnico.Location = new System.Drawing.Point(289, 303);
            this.txb_nome_tecnico.Name = "txb_nome_tecnico";
            this.txb_nome_tecnico.Size = new System.Drawing.Size(280, 31);
            this.txb_nome_tecnico.TabIndex = 9;
            // 
            // lbl_abreProcesso
            // 
            this.lbl_abreProcesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_abreProcesso.AutoSize = true;
            this.lbl_abreProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abreProcesso.Location = new System.Drawing.Point(3, 248);
            this.lbl_abreProcesso.Name = "lbl_abreProcesso";
            this.lbl_abreProcesso.Size = new System.Drawing.Size(280, 25);
            this.lbl_abreProcesso.TabIndex = 11;
            this.lbl_abreProcesso.Text = "Quem abriu a manutenção?";
            // 
            // cbb_usuario
            // 
            this.cbb_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_usuario.FormattingEnabled = true;
            this.cbb_usuario.Location = new System.Drawing.Point(289, 244);
            this.cbb_usuario.Name = "cbb_usuario";
            this.cbb_usuario.Size = new System.Drawing.Size(280, 33);
            this.cbb_usuario.TabIndex = 12;
            this.cbb_usuario.DropDown += new System.EventHandler(this.cbb_usuario_DropDown);
            // 
            // lbl_fecha_manutencao
            // 
            this.lbl_fecha_manutencao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha_manutencao.AutoSize = true;
            this.lbl_fecha_manutencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_manutencao.Location = new System.Drawing.Point(3, 178);
            this.lbl_fecha_manutencao.Name = "lbl_fecha_manutencao";
            this.lbl_fecha_manutencao.Size = new System.Drawing.Size(280, 50);
            this.lbl_fecha_manutencao.TabIndex = 13;
            this.lbl_fecha_manutencao.Text = "Data de término da manutenção.";
            // 
            // dateTime_fechamento
            // 
            this.dateTime_fechamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTime_fechamento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_fechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_fechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_fechamento.Location = new System.Drawing.Point(289, 187);
            this.dateTime_fechamento.Name = "dateTime_fechamento";
            this.dateTime_fechamento.Size = new System.Drawing.Size(280, 31);
            this.dateTime_fechamento.TabIndex = 14;
            // 
            // lbl_observacoes
            // 
            this.lbl_observacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_observacoes.AutoSize = true;
            this.lbl_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observacoes.Location = new System.Drawing.Point(3, 364);
            this.lbl_observacoes.Name = "lbl_observacoes";
            this.lbl_observacoes.Size = new System.Drawing.Size(280, 25);
            this.lbl_observacoes.TabIndex = 16;
            this.lbl_observacoes.Text = "Observações:";
            // 
            // txb_observacoes
            // 
            this.txb_observacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_observacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_observacoes.Location = new System.Drawing.Point(289, 361);
            this.txb_observacoes.Name = "txb_observacoes";
            this.txb_observacoes.Size = new System.Drawing.Size(280, 31);
            this.txb_observacoes.TabIndex = 17;
            // 
            // lbl_valido
            // 
            this.lbl_valido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_valido.AutoSize = true;
            this.lbl_valido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valido.Location = new System.Drawing.Point(3, 422);
            this.lbl_valido.Name = "lbl_valido";
            this.lbl_valido.Size = new System.Drawing.Size(280, 25);
            this.lbl_valido.TabIndex = 18;
            this.lbl_valido.Text = "Válido?";
            // 
            // txb_valido
            // 
            this.txb_valido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_valido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valido.Location = new System.Drawing.Point(289, 419);
            this.txb_valido.Name = "txb_valido";
            this.txb_valido.Size = new System.Drawing.Size(280, 31);
            this.txb_valido.TabIndex = 19;
            // 
            // frm_manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 526);
            this.Controls.Add(this.tlp_manutencao);
            this.Name = "frm_manutencao";
            this.Load += new System.EventHandler(this.frm_manutencao_Load);
            this.tlp_manutencao.ResumeLayout(false);
            this.tlp_manutencao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_manutencao;
        private System.Windows.Forms.Label lbl_equip;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_manutencao;
        private System.Windows.Forms.Label lbl_aprovador;
        private System.Windows.Forms.TextBox txb_serial;
        private System.Windows.Forms.TextBox txb_prob_descr;
        private System.Windows.Forms.DateTimePicker dateTime_abertura;
        private System.Windows.Forms.TextBox txb_nome_tecnico;
        private System.Windows.Forms.Label lbl_abreProcesso;
        private System.Windows.Forms.ComboBox cbb_usuario;
        private System.Windows.Forms.Label lbl_fecha_manutencao;
        private System.Windows.Forms.DateTimePicker dateTime_fechamento;
        private System.Windows.Forms.Button btn_confirma;
        private System.Windows.Forms.Label lbl_observacoes;
        private System.Windows.Forms.TextBox txb_observacoes;
        private System.Windows.Forms.Label lbl_valido;
        private System.Windows.Forms.TextBox txb_valido;
    }
}