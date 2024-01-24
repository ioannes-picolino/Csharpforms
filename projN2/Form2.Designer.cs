namespace projN2
{
    partial class frm_verif
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
            this.tlp_exibirbanco = new System.Windows.Forms.TableLayoutPanel();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.lbl_confirma = new System.Windows.Forms.Label();
            this.lbl_equip = new System.Windows.Forms.Label();
            this.txb_serial = new System.Windows.Forms.TextBox();
            this.LV_exibirVerif = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlp_exibirbanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_exibirbanco
            // 
            this.tlp_exibirbanco.ColumnCount = 2;
            this.tlp_exibirbanco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_exibirbanco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_exibirbanco.Controls.Add(this.btn_confirma, 1, 5);
            this.tlp_exibirbanco.Controls.Add(this.lbl_confirma, 0, 5);
            this.tlp_exibirbanco.Controls.Add(this.lbl_equip, 0, 0);
            this.tlp_exibirbanco.Controls.Add(this.txb_serial, 1, 0);
            this.tlp_exibirbanco.Controls.Add(this.LV_exibirVerif, 0, 1);
            this.tlp_exibirbanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_exibirbanco.Location = new System.Drawing.Point(0, 0);
            this.tlp_exibirbanco.Name = "tlp_exibirbanco";
            this.tlp_exibirbanco.RowCount = 6;
            this.tlp_exibirbanco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_exibirbanco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_exibirbanco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_exibirbanco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_exibirbanco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_exibirbanco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_exibirbanco.Size = new System.Drawing.Size(800, 450);
            this.tlp_exibirbanco.TabIndex = 0;
            // 
            // btn_confirma
            // 
            this.btn_confirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirma.Location = new System.Drawing.Point(403, 378);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(394, 69);
            this.btn_confirma.TabIndex = 10;
            this.btn_confirma.Text = "CONFIRMA";
            this.btn_confirma.UseVisualStyleBackColor = true;
            this.btn_confirma.Click += new System.EventHandler(this.btn_confirma_Click);
            // 
            // lbl_confirma
            // 
            this.lbl_confirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_confirma.AutoSize = true;
            this.lbl_confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirma.Location = new System.Drawing.Point(3, 387);
            this.lbl_confirma.Name = "lbl_confirma";
            this.lbl_confirma.Size = new System.Drawing.Size(394, 50);
            this.lbl_confirma.TabIndex = 9;
            this.lbl_confirma.Text = "Após passar todos os equipamentos, aperte confirma.";
            // 
            // lbl_equip
            // 
            this.lbl_equip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_equip.AutoSize = true;
            this.lbl_equip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equip.Location = new System.Drawing.Point(3, 25);
            this.lbl_equip.Name = "lbl_equip";
            this.lbl_equip.Size = new System.Drawing.Size(394, 25);
            this.lbl_equip.TabIndex = 1;
            this.lbl_equip.Text = "Escreva o serial do equipamento.";
            // 
            // txb_serial
            // 
            this.txb_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_serial.Location = new System.Drawing.Point(403, 22);
            this.txb_serial.Name = "txb_serial";
            this.txb_serial.Size = new System.Drawing.Size(394, 31);
            this.txb_serial.TabIndex = 7;
            this.txb_serial.TextChanged += new System.EventHandler(this.txb_serial_TextChanged);
            this.txb_serial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_serial_KeyPress);
            // 
            // LV_exibirVerif
            // 
            this.LV_exibirVerif.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.tlp_exibirbanco.SetColumnSpan(this.LV_exibirVerif, 2);
            this.LV_exibirVerif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_exibirVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_exibirVerif.HideSelection = false;
            this.LV_exibirVerif.Location = new System.Drawing.Point(3, 78);
            this.LV_exibirVerif.Name = "LV_exibirVerif";
            this.tlp_exibirbanco.SetRowSpan(this.LV_exibirVerif, 4);
            this.LV_exibirVerif.Size = new System.Drawing.Size(794, 294);
            this.LV_exibirVerif.TabIndex = 8;
            this.LV_exibirVerif.UseCompatibleStateImageBehavior = false;
            this.LV_exibirVerif.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°Serial";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data de Verificação";
            // 
            // frm_verif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_exibirbanco);
            this.Name = "frm_verif";
            this.Load += new System.EventHandler(this.frm_verif_Load);
            this.tlp_exibirbanco.ResumeLayout(false);
            this.tlp_exibirbanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_exibirbanco;
        private System.Windows.Forms.Label lbl_equip;
        private System.Windows.Forms.TextBox txb_serial;
        private System.Windows.Forms.ListView LV_exibirVerif;
        private System.Windows.Forms.Label lbl_confirma;
        private System.Windows.Forms.Button btn_confirma;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}