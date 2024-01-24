namespace projN2
{
    partial class Frm_adicionar_novo
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
            this.tlp_adiconar_novo = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_loc = new System.Windows.Forms.ComboBox();
            this.cbb_descr = new System.Windows.Forms.ComboBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_equip = new System.Windows.Forms.Label();
            this.txb_serial = new System.Windows.Forms.TextBox();
            this.lbl_equip_descricao = new System.Windows.Forms.Label();
            this.lbl_local = new System.Windows.Forms.Label();
            this.cbb_marca = new System.Windows.Forms.ComboBox();
            this.btn_novo_equip = new System.Windows.Forms.Button();
            this.tlp_adiconar_novo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_adiconar_novo
            // 
            this.tlp_adiconar_novo.ColumnCount = 2;
            this.tlp_adiconar_novo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_adiconar_novo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_adiconar_novo.Controls.Add(this.cbb_loc, 1, 3);
            this.tlp_adiconar_novo.Controls.Add(this.cbb_descr, 1, 2);
            this.tlp_adiconar_novo.Controls.Add(this.lbl_marca, 0, 1);
            this.tlp_adiconar_novo.Controls.Add(this.lbl_equip, 0, 0);
            this.tlp_adiconar_novo.Controls.Add(this.txb_serial, 1, 0);
            this.tlp_adiconar_novo.Controls.Add(this.lbl_equip_descricao, 0, 2);
            this.tlp_adiconar_novo.Controls.Add(this.lbl_local, 0, 3);
            this.tlp_adiconar_novo.Controls.Add(this.cbb_marca, 1, 1);
            this.tlp_adiconar_novo.Controls.Add(this.btn_novo_equip, 1, 4);
            this.tlp_adiconar_novo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_adiconar_novo.Location = new System.Drawing.Point(0, 0);
            this.tlp_adiconar_novo.Name = "tlp_adiconar_novo";
            this.tlp_adiconar_novo.RowCount = 5;
            this.tlp_adiconar_novo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_adiconar_novo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_adiconar_novo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_adiconar_novo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_adiconar_novo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_adiconar_novo.Size = new System.Drawing.Size(629, 337);
            this.tlp_adiconar_novo.TabIndex = 0;
            // 
            // cbb_loc
            // 
            this.cbb_loc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loc.FormattingEnabled = true;
            this.cbb_loc.Location = new System.Drawing.Point(317, 218);
            this.cbb_loc.Name = "cbb_loc";
            this.cbb_loc.Size = new System.Drawing.Size(309, 33);
            this.cbb_loc.TabIndex = 13;
            this.cbb_loc.DropDown += new System.EventHandler(this.cbb_loc_DropDown);
            // 
            // cbb_descr
            // 
            this.cbb_descr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_descr.FormattingEnabled = true;
            this.cbb_descr.Location = new System.Drawing.Point(317, 151);
            this.cbb_descr.Name = "cbb_descr";
            this.cbb_descr.Size = new System.Drawing.Size(309, 33);
            this.cbb_descr.TabIndex = 12;
            this.cbb_descr.DropDown += new System.EventHandler(this.cbb_descr_DropDown);
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.Location = new System.Drawing.Point(3, 75);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(308, 50);
            this.lbl_marca.TabIndex = 8;
            this.lbl_marca.Text = "Selecione a marca do equipamento.";
            // 
            // lbl_equip
            // 
            this.lbl_equip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_equip.AutoSize = true;
            this.lbl_equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equip.Location = new System.Drawing.Point(3, 8);
            this.lbl_equip.Name = "lbl_equip";
            this.lbl_equip.Size = new System.Drawing.Size(308, 50);
            this.lbl_equip.TabIndex = 1;
            this.lbl_equip.Text = "Escreva o serial do equipamento.";
            // 
            // txb_serial
            // 
            this.txb_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_serial.Location = new System.Drawing.Point(317, 18);
            this.txb_serial.Name = "txb_serial";
            this.txb_serial.Size = new System.Drawing.Size(309, 31);
            this.txb_serial.TabIndex = 7;
            // 
            // lbl_equip_descricao
            // 
            this.lbl_equip_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_equip_descricao.AutoSize = true;
            this.lbl_equip_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equip_descricao.Location = new System.Drawing.Point(3, 142);
            this.lbl_equip_descricao.Name = "lbl_equip_descricao";
            this.lbl_equip_descricao.Size = new System.Drawing.Size(308, 50);
            this.lbl_equip_descricao.TabIndex = 9;
            this.lbl_equip_descricao.Text = "Selecione a descrição e modelo do equipamento.";
            // 
            // lbl_local
            // 
            this.lbl_local.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_local.AutoSize = true;
            this.lbl_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_local.Location = new System.Drawing.Point(3, 222);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(308, 25);
            this.lbl_local.TabIndex = 10;
            this.lbl_local.Text = "Selecione o local do aparelho.";
            // 
            // cbb_marca
            // 
            this.cbb_marca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_marca.FormattingEnabled = true;
            this.cbb_marca.Location = new System.Drawing.Point(317, 84);
            this.cbb_marca.Name = "cbb_marca";
            this.cbb_marca.Size = new System.Drawing.Size(309, 33);
            this.cbb_marca.TabIndex = 11;
            this.cbb_marca.DropDown += new System.EventHandler(this.cbb_marca_DropDown);
            // 
            // btn_novo_equip
            // 
            this.btn_novo_equip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_novo_equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo_equip.Location = new System.Drawing.Point(317, 271);
            this.btn_novo_equip.Name = "btn_novo_equip";
            this.btn_novo_equip.Size = new System.Drawing.Size(309, 63);
            this.btn_novo_equip.TabIndex = 14;
            this.btn_novo_equip.Text = "ENVIAR";
            this.btn_novo_equip.UseVisualStyleBackColor = true;
            this.btn_novo_equip.Click += new System.EventHandler(this.btn_novo_equip_Click);
            // 
            // Frm_adicionar_novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 337);
            this.Controls.Add(this.tlp_adiconar_novo);
            this.Name = "Frm_adicionar_novo";
            this.Load += new System.EventHandler(this.btn);
            this.tlp_adiconar_novo.ResumeLayout(false);
            this.tlp_adiconar_novo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_adiconar_novo;
        private System.Windows.Forms.Label lbl_equip;
        private System.Windows.Forms.TextBox txb_serial;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_equip_descricao;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.ComboBox cbb_loc;
        private System.Windows.Forms.ComboBox cbb_descr;
        private System.Windows.Forms.ComboBox cbb_marca;
        private System.Windows.Forms.Button btn_novo_equip;
    }
}