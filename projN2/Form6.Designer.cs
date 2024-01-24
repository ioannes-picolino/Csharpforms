namespace projN2
{
    partial class frm_list_verif_equip
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
            this.tlp_list_verif_equip = new System.Windows.Forms.TableLayoutPanel();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.lbl_confirma = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlp_list_verif_equip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_list_verif_equip
            // 
            this.tlp_list_verif_equip.ColumnCount = 2;
            this.tlp_list_verif_equip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_list_verif_equip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_list_verif_equip.Controls.Add(this.btn_confirma, 1, 3);
            this.tlp_list_verif_equip.Controls.Add(this.lbl_confirma, 0, 3);
            this.tlp_list_verif_equip.Controls.Add(this.listView1, 0, 0);
            this.tlp_list_verif_equip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_list_verif_equip.Location = new System.Drawing.Point(0, 0);
            this.tlp_list_verif_equip.Name = "tlp_list_verif_equip";
            this.tlp_list_verif_equip.RowCount = 4;
            this.tlp_list_verif_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_list_verif_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_list_verif_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_list_verif_equip.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_list_verif_equip.Size = new System.Drawing.Size(800, 450);
            this.tlp_list_verif_equip.TabIndex = 1;
            // 
            // btn_confirma
            // 
            this.btn_confirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirma.Location = new System.Drawing.Point(403, 339);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(394, 108);
            this.btn_confirma.TabIndex = 11;
            this.btn_confirma.Text = "CONFIRMA";
            this.btn_confirma.UseVisualStyleBackColor = true;
            this.btn_confirma.Click += new System.EventHandler(this.btn_confirma_Click);
            // 
            // lbl_confirma
            // 
            this.lbl_confirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_confirma.AutoSize = true;
            this.lbl_confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirma.Location = new System.Drawing.Point(3, 380);
            this.lbl_confirma.Name = "lbl_confirma";
            this.lbl_confirma.Size = new System.Drawing.Size(394, 25);
            this.lbl_confirma.TabIndex = 10;
            this.lbl_confirma.Text = "Aperte confirma para continuar.";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.tlp_list_verif_equip.SetColumnSpan(this.listView1, 2);
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.tlp_list_verif_equip.SetRowSpan(this.listView1, 3);
            this.listView1.Size = new System.Drawing.Size(794, 330);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°Serial";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data de Verificação";
            this.columnHeader2.Width = 214;
            // 
            // frm_list_verif_equip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlp_list_verif_equip);
            this.Name = "frm_list_verif_equip";
            this.tlp_list_verif_equip.ResumeLayout(false);
            this.tlp_list_verif_equip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_list_verif_equip;
        private System.Windows.Forms.Button btn_confirma;
        private System.Windows.Forms.Label lbl_confirma;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}